using System;
using ShadowrunLogic;

namespace ShadowrunCoreContent
{
	public class Sword : AbstractMeleeWeapon
	{
		public override int Damage (){
			return 3;
		}

		public override DamageType DamageType (){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int AP (){
			return -2;
		}


		public override string Name (){
			return "Sword";
		}

		public override int Accuracy(){
			return 6;
		}

		public override MeleeWeaponSkills Skill ()
		{
			return MeleeWeaponSkills.Blades;
		}
	}
}

