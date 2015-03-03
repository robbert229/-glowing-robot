using System;

namespace ShadowrunLogic
{
	public abstract class AbstractMeleeWeapon : IManifestItem
	{
		public string TypeString(){
			return WeaponType().ToString();
		}

		public abstract int Damage();
		public abstract DamageType DamageType();
		public abstract int AP();
		public abstract MeleeWeaponType WeaponType();
		public abstract string Name();
		public abstract int Accuracy();
		public abstract MeleeWeaponSkills Skill();
	}
}

