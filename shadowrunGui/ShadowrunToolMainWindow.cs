using System;
using Gtk;

using ShadowrunLogic;
using ShadowrunCoreContent;
using System.Collections.Generic;
using ShadowrunGui;

public partial class ShadowrunToolMainWindow: Gtk.Window
{	
	private List<IManifest<IManifestItem>> rangedWeaponManifests;
	private List<IManifest<IManifestItem>> meleeWeaponManifests;
	private List<IManifest<IManifestItem>> attributeManifests;

	private List<Character> characterList;

	public ShadowrunToolMainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		rangedWeaponManifests = new List<IManifest<IManifestItem>>();
		meleeWeaponManifests = new List<IManifest<IManifestItem>>();
		attributeManifests = new List<IManifest<IManifestItem>>();
		LoadContentFromManifests();
	}

	private void LoadContentFromManifests ()
	{
		rangedWeaponManifests.Add(new ShadowrunCoreContent.RangedWeaponsManifest());
		meleeWeaponManifests.Add (new ShadowrunCoreContent.MeleeWeaponsManifest());
		attributeManifests.Add(new ShadowrunCoreContent.AttributesManifest());
	}

	#region FormEvents
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void AttributeImport_Click (object sender, EventArgs e)
	{
		var attributesImportWindow = new ImportWindow(attributeManifests,"Attribute Import");
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
		var rangedImportWeaponWindow = new ImportWindow(rangedWeaponManifests,"Ranged Weapon Import");
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
		var meleeImportWeaponWindow = new ImportWindow(meleeWeaponManifests,"Melee Weapon Import");
		meleeImportWeaponWindow.TransientFor = this;

		meleeImportWeaponWindow.Destroyed+= delegate {
			if(meleeImportWeaponWindow.selectedItem == null)
				return;
			var selectedMeleeWeapon = (AbstractMeleeWeapon)meleeImportWeaponWindow.selectedItem;
			SetRenderedMeleeWeapon(selectedMeleeWeapon);
		};
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
	#endregion
}