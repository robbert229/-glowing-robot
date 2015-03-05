using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class CeskaBlackScorpion : AbstractRangedWeapon
	{
		public override int Damage() {
			return 6;
		}

		public override DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int Accuracy() {
			return 5;
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
			return 35;
		}

		public override string Name(){
			return "Ceska Black Scorpion";
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

