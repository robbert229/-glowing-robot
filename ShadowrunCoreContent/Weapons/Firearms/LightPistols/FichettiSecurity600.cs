using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class FichettiSecurity600 : IRangedWeapon
	{
		public int Damage() {
			return 7;
		}

		public DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public int Accuracy() {
			return 7;
		}

		public int AP ()
		{
			return 0;
		} 

		public RangedWeaponType WeaponType() {
			return RangedWeaponType.Tazer;
		}

		public RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			return rfm;
		}

		public int MagSize(){
			return 30;
		}

		public string Name(){
			return "Fichetti Security 600";
		}

		public int Recoil(){
			return 1;
		}
	}
}

