using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

	private BaseWeapon newWeapon;

	// Use this for initialization.
		void Start() {
		CreateWeapon ();
		Debug.Log(newWeapon.ItemName);
		Debug.Log(newWeapon.ItemDescription);
		Debug.Log(newWeapon.ItemID.ToString ());
		Debug.Log(newWeapon.WeaponType.ToString ());
		Debug.Log(newWeapon.Stamina.ToString ());
		Debug.Log(newWeapon.Intellect.ToString ());
	}

	public void CreateWeapon() {
		newWeapon = new BaseWeapon ();

		// Assign name to the weapon.
		newWeapon.ItemName = "W" + Random.Range (1, 101);

		// Create weapon description.
		newWeapon.ItemDescription = "This is a new Weapon.";

		// Set weapon ID.
		newWeapon.ItemID = Random.Range (1, 101);
		
		// Set weapon type.
		ChooseWeaponType ();

		// Set weapon stats.
		newWeapon.Stamina = Random.Range (1, 11);
		newWeapon.Endurance = Random.Range (1, 11);
		newWeapon.Strength = Random.Range (1, 11);
		newWeapon.Intellect = Random.Range (1, 11);

		// Set spell effect ID.
		newWeapon.SpellEffectID = Random.Range (1, 101);
	}

	private void ChooseWeaponType() {
		int randomTypeID = Random.Range (1, 7);
		if (randomTypeID == 1) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
		} else if (randomTypeID == 2) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
		} else if (randomTypeID == 3) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
		} else if (randomTypeID == 4) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		} else if (randomTypeID == 5) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
		} else if (randomTypeID == 6) {
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.POLEARM;
		}
	}
}
