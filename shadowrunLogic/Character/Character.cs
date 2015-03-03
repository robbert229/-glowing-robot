using System;

namespace ShadowrunLogic
{
	public class Character
	{
		public AbstractAttributes attributes { get; protected set; }
		public AbstractMeleeWeapon meleeWeapon {get; protected set;}
		public AbstractRangedWeapon rangedWeapon {get; protected set;}

		public Character (AbstractAttributes attributes,AbstractRangedWeapon rangedWeapon, AbstractMeleeWeapon meleeWeapon)
		{
			this.attributes = attributes;
			this.rangedWeapon = rangedWeapon;
			this.meleeWeapon = meleeWeapon;
		}
	}
}

