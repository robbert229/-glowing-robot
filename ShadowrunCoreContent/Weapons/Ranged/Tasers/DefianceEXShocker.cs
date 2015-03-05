using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class DefianceEXShocker : AbstractRangedWeapon
	{
		public override int Damage() {
			return 9;
		}

		public override DamageType DamageType(){
			return ShadowrunLogic.DamageType.Stun;
		}

		public override int Accuracy() {
			return 4;
		}

		public override int AP ()
		{
			return -5;
		} 

		public override RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SingleShot = true;
			return rfm;
		}

		public override int MagSize(){
			return 4;
		}

		public override string Name(){
			return "Defiance EX Shocker";
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

