using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class AresCrusaderII : AbstractRangedWeapon
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

		public override RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			rfm.BurstFire = true;
			return rfm;
		}

		public override int MagSize(){
			return 40;
		}

		public override string Name(){
			return "Ares Crusade II";
		}
				
		public override int Recoil(){
			return 2;
		}

		public override RangedWeaponSkills Skill ()
		{
			return RangedWeaponSkills.Automatics;
		}
	}
}

