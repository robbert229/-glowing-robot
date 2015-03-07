using System;

namespace ShadowrunLogic
{
	[Serializable]
	public class Character
	{
		public AbstractAttributes attributes { get; protected set; }
		public AbstractMeleeWeapon meleeWeapon {get; protected set;}
		public AbstractRangedWeapon rangedWeapon {get; protected set;}
		public Boolean isBot { get; set; }


		public int initiative { get; set; }

		public Character (AbstractAttributes attributes,AbstractRangedWeapon rangedWeapon, AbstractMeleeWeapon meleeWeapon, bool auto)
		{
			this.attributes = attributes.Clone();
			this.rangedWeapon = rangedWeapon.Clone ();
			this.meleeWeapon = meleeWeapon.Clone();
			this.isBot = auto;
		}

		public Character(){

		}

		public override string ToString ()
		{
			return string.Format ("[Character: attributes={0}, meleeWeapon={1}, rangedWeapon={2}]", attributes, meleeWeapon, rangedWeapon);
		}
	}
}

