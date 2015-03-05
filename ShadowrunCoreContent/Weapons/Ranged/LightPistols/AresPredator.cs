using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class AresPredator : AbstractRangedWeapon
	{
		public override int Damage() {
			return 7;
		}

		public override DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int Accuracy() {
			return 6;
		}

		public override int AP ()
		{
			return -1;
		} 

		public override RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			rfm.SingleShot = true;
			return rfm;
		}

		public override int MagSize(){
			return 6;
		}

		public override string Name(){
			return "Ares Predator";
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

