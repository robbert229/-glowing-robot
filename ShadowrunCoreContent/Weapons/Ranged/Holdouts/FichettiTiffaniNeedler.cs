using System;
using ShadowrunLogic;
namespace ShadowrunCoreContent
{
	public class FichettiTiffaniNeedler : AbstractRangedWeapon
	{
		public override int Damage() {
			return 8;
		}

		public override DamageType DamageType(){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int Accuracy() {
			return 5;
		}

		public override int AP ()
		{
			return 5;
		} 

		public override RangedFiringModes FiringModes() {
			RangedFiringModes rfm = new RangedFiringModes();
			rfm.SemiAutomatic = true;
			return rfm;
		}

		public override int MagSize(){
			return 4;
		}

		public override string Name(){
			return "Fichetti Tiffani Needler";
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

