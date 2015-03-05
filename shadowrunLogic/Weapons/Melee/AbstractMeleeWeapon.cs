using System;

namespace ShadowrunLogic
{
	public abstract class AbstractMeleeWeapon : IManifestItem
	{
		public string TypeString(){
			return Skill().ToString();
		}

		public abstract int Damage();
		public abstract DamageType DamageType();
		public abstract int AP();
		public abstract string Name();
		public abstract int Accuracy();
		public abstract MeleeWeaponSkills Skill();

		public AbstractMeleeWeapon Clone ()
		{
			return new CustomMeleeWeapon(
				Damage (),
				DamageType (),
				AP (),
				Name (),
				Accuracy (),
				Skill()
			);
		}

		public override string ToString ()
		{
			return string.Format ("[AbstractMeleeWeapon TypeString={0}, Damage={1}, DamageType={2}, AP={3}, Name={4}, Accuracy={5}, Skill={6}]",
				new object[]{
					TypeString(),
					Damage(),
					DamageType() == ShadowrunLogic.DamageType.Physical ? "Physical" : "Stun",
					AP(),
					Name(),
					Accuracy(),
					Skill()
				}
			);
		}
	}
}

