using System;

namespace ShadowrunLogic
{
	public class CustomAttributes : AbstractAttributes
	{
		private int body;
		private int agility;
		private int reaction;
		private int strength;
		private int willpower;
		private int logic;
		private int intuition;
		private int charisma;
		private int initiativeDice;
		private int initiativeModifier;
		private int armor;
		private string name;
		private AttributeType attributeType;

		private int archery;
		private int automatics;
		private int blades;
		private int clubs;
		private int heavyweapons;
		private int longarms;
		private int pistols;
		private int throwingWeapons;
		private int unarmedCombat;

		public CustomAttributes (int body,
		                         int agility,
		                         int reaction,
		                         int strength,
		                         int willpower,
		                         int logic,
		                         int intuition,
		                         int charisma,
		                         int initiativeDice,
		                         int initiativeModifier,
		                         int armor,
		                         string name,
		                         AttributeType attributeType,
		                         int archery,
		                         int automatics,
		                         int blades,
		                         int clubs,
		                         int heavyweapons,
		                         int longarms,
		                         int pistols,
		                         int throwingWeapons,
		                         int unarmedCombat
		                         )
		{
			this.body = body;
			this.agility = agility;
			this.reaction = reaction;
			this.strength = strength;
			this.willpower = willpower;
			this.logic = logic;
			this.intuition = intuition;
			this.charisma = charisma;
			this.initiativeDice = initiativeDice;
			this.initiativeModifier = initiativeModifier;
			this.armor = armor;
			this.name = name;
			this.attributeType = attributeType;
			this.archery = archery;
			this.automatics = automatics;
			this.blades = blades;
			this.clubs = clubs;
			this.heavyweapons = heavyweapons;
			this.longarms = longarms;
			this.pistols = pistols;
			this.throwingWeapons = throwingWeapons;
			this.unarmedCombat = unarmedCombat;
		}
		#region implemented abstract members of ShadowrunLogic.AbstractAttributes
		public override int Body ()
		{
			return body;
		}
		public override int Agility ()
		{
			return agility;
		}
		public override int Reaction ()
		{
			return reaction;
		}
		public override int Strength ()
		{
			return strength;
		}
		public override int Willpower ()
		{
			return willpower;
		}
		public override int Logic ()
		{
			return logic;
		}
		public override int Intuition ()
		{
			return intuition;
		}
		public override int Charisma ()
		{
			return charisma;
		}
		public override int InitiativeDice ()
		{
			return initiativeDice;
		}
		public override int InitiativeModifier ()
		{
			return initiativeModifier;
		}
		public override int Armor ()
		{
			return armor;
		}
		public override string Name ()
		{
			return name;
		}
		public override ShadowrunLogic.AttributeType AttributeType ()
		{
			return attributeType;
		}
		public override int Archery ()
		{
			return archery;
		}
		public override int Automatics ()
		{
			return automatics;
		}
		public override int Blades ()
		{
			return blades;
		}
		public override int Clubs ()
		{
			return clubs;
		}
		public override int HeavyWeapons ()
		{
			return heavyweapons;
		}
		public override int Longarms ()
		{
			return longarms;
		}
		public override int Pistols ()
		{
			return pistols;
		}
		public override int ThrowingWeapons ()
		{
			return throwingWeapons;
		}
		public override int UnarmedCombat ()
		{
			return unarmedCombat;
		}
		#endregion

	}
}

