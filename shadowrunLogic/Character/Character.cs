using System;

namespace ShadowrunLogic
{
	[Serializable]
	public class Character
	{
		public AbstractAttributes attributes { get; protected set; }
		public AbstractMeleeWeapon meleeWeapon {get; protected set;}
		public AbstractRangedWeapon rangedWeapon {get; protected set;}

		public int initiative { get; set; }

		public Character (AbstractAttributes attributes,AbstractRangedWeapon rangedWeapon, AbstractMeleeWeapon meleeWeapon)
		{
			this.attributes = attributes.Clone();
			this.rangedWeapon = rangedWeapon.Clone ();
			this.meleeWeapon = meleeWeapon.Clone();
		}

		public Character(){

		}

		public override string ToString ()
		{
			return string.Format ("[Character: attributes={0}, meleeWeapon={1}, rangedWeapon={2}]", attributes, meleeWeapon, rangedWeapon);
		}
	}
}

