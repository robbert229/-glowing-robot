using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class AresLightFire70 : AbstractRangedWeapon
	{
		public override int Damage() {
			return 6;
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
			return RangedWeaponType.LightPistols;
		}

		public override RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			return rfm;
		}

		public override int MagSize(){
			return 16;
		}

		public override string Name(){
			return "Ares Light Fire 70";
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

