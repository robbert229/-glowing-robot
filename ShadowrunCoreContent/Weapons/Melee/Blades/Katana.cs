using System;
using ShadowrunLogic;

namespace ShadowrunCoreContent
{
	public class Katana : AbstractMeleeWeapon
	{
		public override int Damage (){
			return 3;
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
			return "Katana";
		}

		public override int Accuracy(){
			return 7;
		}
	}
}

