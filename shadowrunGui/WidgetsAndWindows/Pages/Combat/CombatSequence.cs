using System;
using ShadowrunLogic;
using System.Collections.Generic;
using Gtk;

namespace ShadowrunGui
{
	public delegate void CallBack();
	public class CombatSequence
	{
		private Character attacker;
		private Character defender;
		public CombatSequence (Character attacker, Character defender, CallBack c)
		{
			this.attacker = attacker;
			this.defender = defender;

			RollToHit();
			c();
		}



		private void RollToHit(){
			int attackerBaseDicePool = attacker.attributes.Agility() + 
				attacker.attributes.getSkillRating(attacker.rangedWeapon.Skill());
			int attackerDicePoolPenalties = attacker.attributes.GetDamageModifier();
			int attackerTotalPool = attackerBaseDicePool + attackerDicePoolPenalties;

			if (attacker.isBot) {
				int hits = Dice.RollPool(attackerTotalPool);
				var mw = new MessageWindow("Hits",hits.ToString() + " hits were rolled");
				if(hits > 0)
					mw.Destroyed += delegate {
						RollToDodge(hits);
					};
			} else {
				PlayerRollToHit(attackerBaseDicePool,attackerDicePoolPenalties);
			}
		}

		private void PlayerRollToHit(int basePool, int penalties){
			var iw = new InputWindow(
				"Roll To Hit", 
				"BasePool: " + basePool + 
				", Penalties: " + penalties + 
				", Dice To Roll: " + (basePool + penalties).ToString());

			iw.Destroyed+= delegate {
				try {
					int i= Int32.Parse(iw.input);
					if( i > 0)
						RollToDodge(i);
				
				} catch (Exception ex){
					new MessageWindow("Invalid Input","Error: " + ex.Message);
					PlayerRollToHit(basePool,penalties);
				}
			};
		}

		private void RollToDodge (int attackHits)
		{

			int defenderBaseDicePool = defender.attributes.Agility () + defender.attributes.Intuition ();
			int defenderPenaltyPool = defender.attributes.GetDamageModifier ();

			int defenderTotalPool = defenderBaseDicePool + defenderPenaltyPool;

			if (defender.isBot) {
				int defenderHits = Dice.RollPool (defenderTotalPool);
				int netHits = attackHits - defenderHits;
				var mw = new MessageWindow (
					"Defender Rolled",
					"Defender Rolled " + defenderHits.ToString () + 
					" Hits! Attacker Net Hits Are " + netHits + 
					(netHits <= 0 ? ", the shot missed!" : ", the shot hit!")
				);

				if (netHits > 0)
					mw.Destroyed += delegate {
						ResistDamage (netHits);
					};
			} else {
				PlayerRollToDodge(attackHits,defenderBaseDicePool,defenderPenaltyPool);
			}
		}

		private void PlayerRollToDodge(int attackerHits, int basePool, int penalties){
			var iw = new InputWindow(
				"Roll to Dodge", 
				"BasePool: " + basePool + 
				", Penalties: " + penalties + 
				", Dice To Roll: " + (basePool + penalties).ToString());

			iw.Destroyed+= delegate {
				try {
					int netHits = attackerHits - Int32.Parse(iw.input);

					if( netHits > 0)
						ResistDamage(netHits);
				
				} catch (Exception ex){
					new MessageWindow("Invalid Input","Error: " + ex.Message);
					PlayerRollToDodge(attackerHits, basePool, penalties);
				}
			};
		}

		private void ResistDamage (int netHits)
		{
			int resistDamagePool = defender.attributes.Armor () + defender.attributes.Body () + attacker.rangedWeapon.AP();

			if (defender.isBot) {
				int hits = Dice.RollPool (resistDamagePool);
				var mw = new MessageWindow("Resist Dice",hits + " hits were rolled to negate damage");
				mw.Destroyed += delegate {
					ResolveDamage(netHits,hits);
				};

			} else {
				PlayerResistDamage(netHits,resistDamagePool);
			}
		}

		private void PlayerResistDamage(int netHits,int pool){
			var iw = new InputWindow(
				"Roll to Resist", 
				", Dice To Roll: " + pool);

			iw.Destroyed+= delegate {
				try {
					int res = Int32.Parse(iw.input);
					ResolveDamage(netHits,res);
				
				} catch (Exception ex){
					new MessageWindow("Invalid Input","Error: " + ex.Message);
					PlayerResistDamage(netHits,pool);
				}
			};
		}

		private void ResolveDamage (int netHits, int resistHits)
		{
			DamageType damageType;
			if (netHits + attacker.rangedWeapon.Damage () > defender.attributes.Armor () + attacker.rangedWeapon.AP ()) {
				damageType = DamageType.Physical;
			} else {
				damageType = DamageType.Stun;
			}

			int damageDealt = netHits + attacker.rangedWeapon.Damage () - resistHits;
			var mw = new MessageWindow (
				"Results",
				damageDealt + " " + 
				(DamageType.Physical == damageType ? "physical" : "stun") + 
				" damage was dealt"
			);

			if (damageDealt > 0) {
				if(damageType == DamageType.Physical){
					defender.attributes.PhysicalDamageTaken += damageDealt;
				} else {
					defender.attributes.StunDamageTaken += damageDealt;
				}
			}


		}
	}
}

