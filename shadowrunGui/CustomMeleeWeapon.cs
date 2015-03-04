using System;
using ShadowrunLogic;

namespace ShadowrunCoreContent
{
	public class CustomMeleeWeapon : AbstractMeleeWeapon
	{
		private int damage;
		private DamageType damageType;
		private int ap;
		private MeleeWeaponType meleeWeaponType;
		private string name;
		private int accuracy;
		private MeleeWeaponSkills meleeWeaponSkills;

		public CustomMeleeWeapon (int damage, DamageType damageType, int ap,
		                          MeleeWeaponType meleeWeaponType,string name,int accuracy,
		                          MeleeWeaponSkills meleeWeaponSkills)
		{
			this.damage = damage;
			this.damageType = damageType;
			this.ap = ap;
			this.meleeWeaponType = meleeWeaponType;
			this.name = name;
			this.accuracy = accuracy;
			this.meleeWeaponSkills = meleeWeaponSkills;
		}
		#region implemented abstract members of ShadowrunLogic.AbstractMeleeWeapon
		public override int Damage ()
		{
			return damage;
		}

		public override ShadowrunLogic.DamageType DamageType ()
		{
			return damageType;
		}

		public override int AP ()
		{
			return ap;
		}

		public override MeleeWeaponType WeaponType ()
		{
			return meleeWeaponType;
		}

		public override string Name ()
		{
			return name;
		}

		public override int Accuracy ()
		{
			return accuracy;
		}

		public override MeleeWeaponSkills Skill ()
		{
			return meleeWeaponSkills;
		}
		#endregion

	}
}

