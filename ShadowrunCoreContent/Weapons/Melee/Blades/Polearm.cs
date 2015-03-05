using System;
using ShadowrunLogic;

namespace ShadowrunCoreContent
{
	public class Polearm : AbstractMeleeWeapon
	{
		public override int Damage (){
			return 3;
		}

		public override DamageType DamageType (){
			return ShadowrunLogic.DamageType.Physical;
		}

		public override int AP (){
			return -2;
		}
		public override string Name (){
			return "Polearm";
		}

		public override int Accuracy(){
			return 5;
		}

		public override MeleeWeaponSkills Skill ()
		{
			return MeleeWeaponSkills.Blades;
		}
	}
}

