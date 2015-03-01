using System;

namespace ShadowrunLogic
{
	public class Character
	{
		public int Body { get; protected set; }
		public int Agility {get; protected set; }
		public int Reaction { get; protected set; }
		public int Willpower { get; protected set; }
		public int Logic {get; protected set; }
		public int Intuition { get; protected set; }
		public int Charisma { get; protected set; }

		public int InitiativeDice { get; protected set; }
		public int InitiativeModifier {get; protected set; }

		public int Armor { get; protected set; }

		public int MeleeSkill { get; protected set; }
		public int RangedSkill { get; protected set; }

		public int RangedDamage { get; protected set; }
		public DamageType RangedDamageType { get;protected set; }
		public int RangedAccuracy { get; protected set; }







		public int StunDamageTaken { get; set; }
		public int PhysicalDamageTaken { get; set; }

		public int MaxStunDamage(){
			return 8 + (Willpower / 2);
		}

		public int MaxPhysixalDamage() {
			return 8 + (Body / 2);
		}

		public int GetDamageModifier(){
			int sMod = StunDamageTaken / 3;
			int pMod = PhysicalDamageTaken / 3;

			if(sMod > pMod)
				return sMod;
			return pMod;
		}
	}
}

