using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class DefianceEXShocker : IRangedWeapon
	{
		public int Damage() {
			return 9;
		}

		public DamageType DamageType(){
			return ShadowrunLogic.DamageType.Stun;
		}

		public int Accuracy() {
			return 4;
		}

		public int AP ()
		{
			return -5;
		} 

		public RangedWeaponType WeaponType() {
			return RangedWeaponType.Tazer;
		}

		public RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SingleShot = true;
			return rfm;
		}

		public int MagSize(){
			return 4;
		}

		public string Name(){
			return "Defiance EX Shocker";
		}

		public int Recoil(){
			return 0;
		}

		public string TypeString(){
			return DamageType().ToString();
		}
	}
}

