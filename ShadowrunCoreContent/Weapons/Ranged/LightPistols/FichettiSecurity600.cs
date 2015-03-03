using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class FichettiSecurity600 : AbstractRangedWeapon
	{
		public override int Damage() {
			return 7;
		}

		public override DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int Accuracy() {
			return 7;
		}

		public override int AP ()
		{
			return 0;
		} 

		public override RangedWeaponType WeaponType() {
			return RangedWeaponType.Tazer;
		}

		public override RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			return rfm;
		}

		public override int MagSize(){
			return 30;
		}

		public override string Name(){
			return "Fichetti Security 600";
		}

		public override int Recoil(){
			return 1;
		}
	}
}

