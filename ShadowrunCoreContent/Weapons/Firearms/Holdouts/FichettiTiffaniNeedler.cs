using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class FichettiTiffaniNeedler : IRangedWeapon
	{
		public int Damage() {
			return 8;
		}

		public DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public int Accuracy() {
			return 5;
		}

		public int AP ()
		{
			return 5;
		} 

		public RangedWeaponType WeaponType() {
			return RangedWeaponType.Holdout;
		}

		public RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			return rfm;
		}

		public int MagSize(){
			return 4;
		}

		public string Name(){
			return "Fichetti Tiffani Needler";
		}

		public int Recoil(){
			return 0;
		}
	}
}

