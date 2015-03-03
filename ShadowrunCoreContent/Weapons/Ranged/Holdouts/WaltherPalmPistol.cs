using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class WaltherPalmPistol : AbstractRangedWeapon
	{
		public override int Damage() {
			return 7;
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
			rfm.SingleShot = true;
			rfm.SemiAutomaticBurst = true;
			return rfm;
		}

		public override int MagSize(){
			return 2;
		}

		public override string Name(){
			return "Walther Palm Pistol";
		}

		public override int Recoil(){
			return 0;
		}

		public override RangedWeaponSkills Skill ()
		{
			return RangedWeaponSkills.Pistols;
		}
	}
}

