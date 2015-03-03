using System;

namespace ShadowrunLogic
{
	public abstract class AbstractAttributes : IManifestItem
	{
		#region attributes
		public abstract int Body();
		public abstract int Agility();
		public abstract int Reaction();
		public abstract int Strength();
		public abstract int Willpower();
		public abstract int Logic();
		public abstract int Intuition();
		public abstract int Charisma();
		public abstract int InitiativeDice();
		public abstract int InitiativeModifier();
		#endregion

		public abstract int Armor();

		public int StunDamageTaken { get; set; }
		public int PhysicalDamageTaken { get; set; }

		public int MaxStunDamage(){
			return 8 + (Willpower() / 2);
		}
		public int MaxPhysixalDamage() {
			return 8 + (Body() / 2);
		}

		public int GetDamageModifier(){
			int sMod = StunDamageTaken / 3;
			int pMod = PhysicalDamageTaken / 3;

			if(sMod > pMod)
				return sMod;
			return pMod;
		}

		public abstract string Name ();

		public abstract AttributeType AttributeType();
		public string TypeString ()
		{
			return AttributeType().ToString();
		}

		#region combat-skills
		public abstract int Archery();
		public abstract int Automatics();
		public abstract int Blades();
		public abstract int Clubs();
		public abstract int HeavyWeapons();
		public abstract int Longarms();
		public abstract int Pistols();
		public abstract int ThrowingWeapons();
		public abstract int UnarmedCombat();
		#endregion
	}
}

