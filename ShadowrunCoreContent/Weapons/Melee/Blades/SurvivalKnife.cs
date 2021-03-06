using System;
using ShadowrunLogic;

namespace ShadowrunCoreContent
{
	public class SurvivalKnife : AbstractMeleeWeapon
	{
		public override int Damage (){
			return 2;
		}

		public override DamageType DamageType (){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int AP (){
			return -1;
		}


		public override string Name (){
			return "Survival Knife";
		}

		public override int Accuracy(){
			return 5;
		}

		public override MeleeWeaponSkills Skill ()
		{
			return MeleeWeaponSkills.Blades;
		}
	}
}

