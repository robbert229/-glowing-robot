using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class Beretta201T : AbstractRangedWeapon
	{
		public override int Damage() {
			return 6;
		}

		public override DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int Accuracy() {
			return 6;
		}

		public override int AP ()
		{
			return 0;
		} 

		public override RangedWeaponType WeaponType() {
			return RangedWeaponType.LightPistols;
		}

		public override RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			rfm.SemiAutomaticBurst = true;
			return rfm;
		}

		public override int MagSize(){
			return 21;
		}

		public override string Name(){
			return "Beretta201T";
		}

		public override int Recoil(){
			return 1;
		}
	}
}

