using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour {

	private BasePotion newPotion;

	// Use this for initialization.
	void Start () {
		CreatePotion ();
		Debug.Log(newPotion.ItemName);
		Debug.Log(newPotion.ItemDescription);
		Debug.Log(newPotion.ItemID.ToString ());
		Debug.Log(newPotion.PotionType.ToString ());
	}
	
	private void CreatePotion(){
		newPotion = new BasePotion ();

		// Assign name to the potion.
		newPotion.ItemName = "Potion";

		// Create potion description.
		newPotion.ItemDescription = "This is a Potion.";

		// Set potion ID.
		newPotion.ItemID = Random.Range (1, 101);

		// Set potion type.
		ChoosePotionType ();
	}

	private void ChoosePotionType() {
		int randomTypeID = Random.Range (1, 8);
		if (randomTypeID == 1) {
			newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
		} else if (randomTypeID == 2) {
			newPotion.PotionType = BasePotion.PotionTypes.ENERGY;
		} else if (randomTypeID == 3) {
			newPotion.PotionType = BasePotion.PotionTypes.ENDURANCE;
		} else if (randomTypeID == 4) {
			newPotion.PotionType = BasePotion.PotionTypes.STRENGTH;
		} else if (randomTypeID == 5) {
			newPotion.PotionType = BasePotion.PotionTypes.INTELLECT;
		} else if (randomTypeID == 6) {
			newPotion.PotionType = BasePotion.PotionTypes.VITALITY;
		} else if (randomTypeID == 7) {
			newPotion.PotionType = BasePotion.PotionTypes.SPEED;
		}
	}
}
