using System;
using ShadowrunLogic;

namespace ShadowrunCoreContent
{
	public class CombatKnife : AbstractMeleeWeapon
	{
		public override int Damage (){
			return 2;
		}

		public override DamageType DamageType (){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int AP (){
			return -3;
		}

		public override MeleeWeaponType WeaponType (){
			return MeleeWeaponType.Blade;
		}

		public override string Name (){
			return "Combat Knife";
		}

		public override int Accuracy(){
			return 6;
		}
	}
}

