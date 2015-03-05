using System;
using Gtk;

using ShadowrunLogic;
using ShadowrunCoreContent;
using System.Collections.Generic;
using ShadowrunGui;

public partial class CharacterImportWindow: Gtk.Window
{	
	private List<IManifest<IManifestItem>> rangedWeaponManifests;
	private List<IManifest<IManifestItem>> meleeWeaponManifests;
	private List<IManifest<IManifestItem>> attributeManifests;

	public Character character;

	public CharacterImportWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		rangedWeaponManifests = new List<IManifest<IManifestItem>>();
		meleeWeaponManifests = new List<IManifest<IManifestItem>>();
		attributeManifests = new List<IManifest<IManifestItem>>();
		LoadContentFromManifests();
	}

	public CharacterImportWindow (Character c): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		rangedWeaponManifests = new List<IManifest<IManifestItem>>();
		meleeWeaponManifests = new List<IManifest<IManifestItem>>();
		attributeManifests = new List<IManifest<IManifestItem>>();
		LoadContentFromManifests();

		SetRenderedAttributes(c.attributes);
		SetRenderedMeleeWeapon(c.meleeWeapon);
		SetRenderedRangedWeapon(c.rangedWeapon);
	}

	private void LoadContentFromManifests ()
	{
		rangedWeaponManifests.Add(new ShadowrunCoreContent.RangedWeaponsManifest());
		meleeWeaponManifests.Add (new ShadowrunCoreContent.MeleeWeaponsManifest());
		attributeManifests.Add(new ShadowrunCoreContent.AttributesManifest());
	}

	#region FormEvents
	protected void AttributeImport_Click (object sender, EventArgs e)
	{
		var attributesImportWindow = new ItemImportWindow(attributeManifests,"Attribute Import");
		attributesImportWindow.TransientFor = this;

		attributesImportWindow.Destroyed+= delegate {
			if(attributesImportWindow.selectedItem == null)
				return;
			var selectedAttributes = (AbstractAttributes)attributesImportWindow.selectedItem;
			SetRenderedAttributes(selectedAttributes);
		};

	}

	protected void RangedWeaponImport_Click (object sender, EventArgs e)
	{
		var rangedImportWeaponWindow = new ItemImportWindow(rangedWeaponManifests,"Ranged Weapon Import");
		rangedImportWeaponWindow.TransientFor = this;

		rangedImportWeaponWindow.Destroyed+= delegate {
			if(rangedImportWeaponWindow.selectedItem == null)
				return;
			var selectedRangedWeapon = (AbstractRangedWeapon)rangedImportWeaponWindow.selectedItem;
			SetRenderedRangedWeapon(selectedRangedWeapon);
		};
	}

	protected void MeleeWeaponImport_Click (object sender, EventArgs e)
	{
		var meleeImportWeaponWindow = new ItemImportWindow(meleeWeaponManifests,"Melee Weapon Import");
		meleeImportWeaponWindow.TransientFor = this;

		meleeImportWeaponWindow.Destroyed+= delegate {
			if(meleeImportWeaponWindow.selectedItem == null)
				return;
			var selectedMeleeWeapon = (AbstractMeleeWeapon)meleeImportWeaponWindow.selectedItem;
			SetRenderedMeleeWeapon(selectedMeleeWeapon);
		};
	
	
	}

	protected void SubmitCharacter_Click (object sender, EventArgs e)
	{
		try {
			this.character = new Character (
				attributesFromFormInput (),
				rangedWeaponFromFormInput (),
				meleeWeaponFromFormInput ()
			);

			this.Destroy ();
		} catch (Exception ex) {
			new MessageWindow(this,"Character Import Window", "Error: " + ex.Message);
		}
	}
	#endregion

	#region DisplayStuff
	protected void SetRenderedRangedWeapon (AbstractRangedWeapon r)
	{
		RangedWeaponName_Textbox.Text = r.Name ();
		RangedDamage_Textbox.Text = r.Damage ().ToString ();
		if (r.DamageType () == DamageType.Stun)
			RangedStunDamage_Radio.Activate ();
		else 
			RangedPhysicalDamage_Radio.Activate ();
		RangedAccuracy_Textbox.Text = r.Accuracy ().ToString ();
		RangedWeaponAP_Textbox.Text = r.AP ().ToString ();
		RangedRecoil_Textbox.Text = r.Recoil ().ToString ();

		var modes = r.FiringModes ();
		SingleShot_Checkbox.Active = modes.SingleShot;
		SemiAutomatic_Checkbox.Active = modes.SemiAutomatic;
		SemiAutomaticBurst_Checkbox.Active = modes.SemiAutomaticBurst;
		BurstFire_Checkbox.Active = modes.BurstFire;
		LongBurst_Checkbox.Active = modes.LongBurst;
		FullAuto_Checkbox.Active = modes.FullAuto;
		MagSize_Textbox.Text = r.MagSize().ToString();

		switch (r.Skill ()) {
		case RangedWeaponSkills.Archery:
			Archery_Radio.Activate ();
			break;
		case RangedWeaponSkills.Automatics:
			Automatics_Radio.Activate ();
			break;
		case RangedWeaponSkills.HeavyWeapons:
			HeavyWeapons_Radio.Activate ();
			break;
		case RangedWeaponSkills.Longarms:
			Longarms_Radio.Activate ();
			break;
		case RangedWeaponSkills.Pistols:
			Pistols_Radio.Activate ();
			break;
		case RangedWeaponSkills.ThrowingWeapons:
			ThrowingWeapons_Radio.Activate ();
			break;
		}
	}

	protected void SetRenderedMeleeWeapon (AbstractMeleeWeapon m)
	{
		MeleeWeaponName_Textbox.Text = m.Name ();
		MeleeAP_Textbox.Text = m.AP ().ToString ();

		if (m.DamageType () == DamageType.Stun)
			MeleeStunDamage_Radio.Activate ();
		else 
			MeleePhysicalDamage_Radio.Activate ();

		MeleeDamage_Textbox.Text = m.Damage ().ToString ();
		MeleeAccuracy_Textbox.Text = m.Accuracy().ToString();

		switch (m.Skill ()) {
		case MeleeWeaponSkills.Blades:
			Blades_Radio.Activate();
			break;
		case MeleeWeaponSkills.Clubs:
			Clubs_Radio.Activate();
			break;
		case MeleeWeaponSkills.UnarmedCombat:
			Unarmed_Radio.Activate();
			break;
		}

	}

	protected void SetRenderedAttributes(AbstractAttributes a){

		this.Armor_Textbox.Text = a.Armor().ToString();

		//attributes
		this.Body_Textbox.Text = a.Body().ToString();
		this.Agility_Textbox.Text = a.Agility().ToString();
		this.Charisma_Textbox.Text = a.Charisma().ToString();
		this.InitiativeDiceCount_Textbox.Text = a.InitiativeDice().ToString();
		this.InitiativeModifier_Textbox.Text = a.InitiativeModifier().ToString();
		this.Intuition_Textbox.Text = a.Intuition().ToString();
		this.Logic_Textbox.Text = a.Logic().ToString();
		this.Reaction_Textbox.Text = a.Reaction().ToString();
		this.Strength_Textbox.Text = a.Strength().ToString();
		this.Willpower_Textbox.Text = a.Willpower().ToString();

		this.Name_Textbox.Text = a.Name();
		//combat skills
		this.Archery_Spinbox.Value = a.Archery();
		this.AutomaticsSpinbox.Value = a.Automatics();
		this.Blades_Spinbox.Value = a.Blades();
		this.Clubs_Spinbox.Value = a.Clubs();
		this.HeavyWeapons_Spinbox.Value = a.HeavyWeapons();
		this.Longarms_Spinbox.Value = a.Longarms();
		this.Pistols_Spinbox.Value = a.Pistols();
		this.ThrowingWeapons_Spinbox.Value = a.ThrowingWeapons();
		this.UnarmedCombat_Spinbox.Value = a.UnarmedCombat();
	}

	protected AbstractAttributes attributesFromFormInput(){
		return new CustomAttributes(
			Int32.Parse(Body_Textbox.Text),
			Int32.Parse(Agility_Textbox.Text),
			Int32.Parse(Reaction_Textbox.Text),
			Int32.Parse(Strength_Textbox.Text),
			Int32.Parse (Willpower_Textbox.Text),
			Int32.Parse (Logic_Textbox.Text),
			Int32.Parse (Intuition_Textbox.Text),
			Int32.Parse (Charisma_Textbox.Text),
			Int32.Parse (InitiativeDiceCount_Textbox.Text),
			Int32.Parse (InitiativeModifier_Textbox.Text),
			Int32.Parse (Armor_Textbox.Text),
			Name_Textbox.Text,
			AttributeType.Custom,
			(int)Archery_Spinbox.Value,
			(int)AutomaticsSpinbox.Value,
			(int)Blades_Spinbox.Value,
			(int)Clubs_Spinbox.Value,
			(int)HeavyWeapons_Spinbox.Value,
			(int)Longarms_Spinbox.Value,
			(int)Pistols_Spinbox.Value,
			(int)ThrowingWeapons_Spinbox.Value,
			(int)UnarmedCombat_Spinbox.Value);
	}

	protected RangedFiringModes rangedFiringModesFromFormInput ()
	{
		RangedFiringModes mode = new RangedFiringModes();
		if(BurstFire_Checkbox.Active)
			mode.BurstFire = true;
		if(FullAuto_Checkbox.Active)
			mode.FullAuto = true;
		if(LongBurst_Checkbox.Active)
			mode.LongBurst = true;
		if(SemiAutomatic_Checkbox.Active)
			mode.SemiAutomatic = true;
		if(SemiAutomaticBurst_Checkbox.Active)
			mode.SemiAutomaticBurst = true;
		if(SingleShot_Checkbox.Active)
			mode.SingleShot = true;
		return mode;
	}

	protected RangedWeaponSkills rangedWeaponSkillFromFormInput ()
	{
		if (Archery_Radio.Active) {
			return RangedWeaponSkills.Archery;
		} else if (Automatics_Radio.Active) {
			return RangedWeaponSkills.Automatics;
		} else if (HeavyWeapons_Radio.Active) { 
			return RangedWeaponSkills.HeavyWeapons;
		} else if (Longarms_Radio.Active) {
			return RangedWeaponSkills.Longarms;
		} else if (Pistols_Radio.Active) {
			return RangedWeaponSkills.Pistols;
		} else if (ThrowingWeapons_Radio.Active) {
			return RangedWeaponSkills.ThrowingWeapons;
		} else {
			throw new ArgumentOutOfRangeException();
		}
	}

	protected AbstractRangedWeapon rangedWeaponFromFormInput ()
	{
		return new CustomRangedWeapon(
			Int32.Parse(MeleeDamage_Textbox.Text),
			(RangedPhysicalDamage_Radio.Active ? DamageType.Physical : DamageType.Stun),
			Int32.Parse(RangedAccuracy_Textbox.Text),
			Int32.Parse(RangedWeaponAP_Textbox.Text),
			rangedFiringModesFromFormInput(),
			Int32.Parse(this.MagSize_Textbox.Text),
			RangedWeaponName_Textbox.Text,
			Int32.Parse(RangedRecoil_Textbox.Text),
			rangedWeaponSkillFromFormInput());

	}

	protected MeleeWeaponSkills meleeWeaponSkillsFromFormInput ()
	{
		if (Blades_Radio.Active) {
			return MeleeWeaponSkills.Blades;
		} else if (Clubs_Radio.Active) {
			return MeleeWeaponSkills.Clubs;
		} else if (Unarmed_Radio.Active) {
			return MeleeWeaponSkills.UnarmedCombat;
		} else {
			throw new ArgumentOutOfRangeException();
		}
	}

	protected AbstractMeleeWeapon meleeWeaponFromFormInput ()
	{
		return new CustomMeleeWeapon(
			Int32.Parse(MeleeDamage_Textbox.Text),
			(MeleePhysicalDamage_Radio.Active ? DamageType.Physical : DamageType.Stun),
			Int32.Parse(MeleeAP_Textbox.Text),
			MeleeWeaponName_Textbox.Text,
			Int32.Parse(MeleeAccuracy_Textbox.Text),
			meleeWeaponSkillsFromFormInput());
	}
	#endregion
}