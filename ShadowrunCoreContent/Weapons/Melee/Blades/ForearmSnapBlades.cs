using System;
using ShadowrunLogic;

namespace ShadowrunCoreContent
{
	public class ForearmSnapBlades : AbstractMeleeWeapon
	{
		public override int Damage (){
			return 2;
		}

		public override DamageType DamageType (){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int AP (){
			return -2;
		}

		public override string Name (){
			return "Forearm snap-blades";
		}

		public override int Accuracy(){
			return 4;
		}

		public override MeleeWeaponSkills Skill ()
		{
			return MeleeWeaponSkills.Blades;
		}
	}
}

