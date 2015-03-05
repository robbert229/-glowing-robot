using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class SteyrTMP : AbstractRangedWeapon
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


		public override RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			rfm.BurstFire = true;
			rfm.FullAuto = true;
			return rfm;
		}

		public override int MagSize(){
			return 30;
		}

		public override string Name(){
			return "Steyr TMP";
		}
				
		public override int Recoil(){
			return 0;
		}

		public override RangedWeaponSkills Skill ()
		{
			return RangedWeaponSkills.Automatics;
		}
	}
}

