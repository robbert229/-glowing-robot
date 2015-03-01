using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class WaltherPalmPistol : IRangedWeapon
	{
		public int Damage() {
			return 7;
		}

		public DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public int Accuracy() {
			return 4;
		}

		public int AP ()
		{
			return 0;
		} 

		public RangedWeaponType WeaponType() {
			return RangedWeaponType.Holdout;
		}

		public RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SingleShot = true;
			rfm.SemiAutomaticBurst = true;
			return rfm;
		}

		public int MagSize(){
			return 2;
		}

		public string Name(){
			return "Walther Palm Pistol";
		}

		public int Recoil(){
			return 0;
		}
	}
}

