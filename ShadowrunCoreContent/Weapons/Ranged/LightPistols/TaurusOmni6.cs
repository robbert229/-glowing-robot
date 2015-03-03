using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class TaurusOmni6 : AbstractRangedWeapon
	{
		public override int Damage() {
			return 7;
		}

		public override DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int Accuracy() {
			return 6;
		}

		public override int AP ()
		{
			return -1;
		} 

		public override RangedWeaponType WeaponType() {
			return RangedWeaponType.LightPistols;
		}

		public override RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			rfm.SingleShot = true;
			return rfm;
		}

		public override int MagSize(){
			return 6;
		}

		public override string Name(){
			return "Taurus Omni-6";
		}
				
		public override int Recoil(){
			return 0;
		}
	}
}

