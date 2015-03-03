using System;
using ShadowrunLogic;

namespace ShadowrunCoreContent
{
	public class CombatAxe : AbstractMeleeWeapon
	{
		public override int Damage (){
			return 5;
		}

		public override DamageType DamageType (){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int AP (){
			return -4;
		}

		public override MeleeWeaponType WeaponType (){
			return MeleeWeaponType.Blade;
		}

		public override string Name (){
			return "Combat Axe";
		}

		public override int Accuracy(){
			return 4;
		}

		public override MeleeWeaponSkills Skill ()
		{
			return MeleeWeaponSkills.Blades;
		}

	}
}

