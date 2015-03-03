using System;
using ShadowrunLogic;

namespace ShadowrunCoreContent
{
	public class Knife : AbstractMeleeWeapon
	{
		public override int Damage (){
			return 1;
		}

		public override DamageType DamageType (){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int AP (){
			return -1;
		}

		public override MeleeWeaponType WeaponType (){
			return MeleeWeaponType.Blade;
		}

		public override string Name (){
			return "Knife";
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

