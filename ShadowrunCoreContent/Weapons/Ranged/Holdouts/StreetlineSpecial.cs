using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class StreetlineSpecial : AbstractRangedWeapon
	{
		public override int Damage() {
			return 6;
		}

		public override DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int Accuracy() {
			return 4;
		}

		public override int AP ()
		{
			return 0;
		} 

		public override RangedWeaponType WeaponType() {
			return RangedWeaponType.Holdout;
		}

		public override RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			return rfm;
		}

		public override int MagSize(){
			return 6;
		}

		public override string Name(){
			return "Streetline Special";
		}

		public override int Recoil(){
			return 0;
		}
	}
}

