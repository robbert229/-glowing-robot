using System;
using ShadowrunLogic;

namespace ShadowrunCoreContent
{
	public class CorporateSecurityAttributes : AbstractAttributes
	{
		#region core-attributes
		public override string Name ()
		{
			return "Corporate Security ";
		}

		public override ShadowrunLogic.AttributeType AttributeType ()
		{
			return ShadowrunLogic.AttributeType.Corporate;
		}

		public override int Body ()
		{
			return 4;
		}

		public override int Agility ()
		{
			return 4;
		}

		public override int Reaction ()
		{
			return 4;
		}

		public override int Strength ()
		{
			return 3;
		}

		public override int Willpower ()
		{
			return 3;
		}

		public override int Logic ()
		{
			return 2;
		}

		public override int Intuition ()
		{
			return 3;
		}

		public override int Charisma ()
		{
			return 3;
		}

		public override int InitiativeDice ()
		{
			return 1;
		}

		public override int InitiativeModifier ()
		{
			return 7;
		}
		#endregion

		public override int Armor ()
		{
			return 12;
		}

		#region combat-skills
		public override int Archery ()
		{
			return 0;
		}

		public override int Automatics ()
		{
			return 3;
		}

		public override int Blades ()
		{
			return 0;
		}

		public override int Clubs ()
		{
			return 0;
		}

		public override int HeavyWeapons ()
		{
			return 0;
		}

		public override int Longarms ()
		{
			return 0;
		}

		public override int Pistols ()
		{
			return 4;
		}

		public override int ThrowingWeapons ()
		{
			return 0;
		}

		public override int UnarmedCombat ()
		{
			return 3;
		}
		#endregion

	}
}

