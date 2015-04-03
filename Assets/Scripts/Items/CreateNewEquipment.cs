using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {
		
	private BaseEquipment newEquipment;
	private string[] itemNames = new string[4] {
		"Common", "Great", "Amazing", "Insane"};
	private string[] itemDescriptions = new string[2] {
		"A new cool Equipment.", "A new not-so-cool Equipment."};
	
	void Start() {
		CreateEquipment ();
		Debug.Log(newEquipment.ItemName);
		Debug.Log(newEquipment.ItemDescription);
		Debug.Log(newEquipment.ItemID.ToString ());
		Debug.Log(newEquipment.EquipmentType.ToString ());
		Debug.Log(newEquipment.Stamina.ToString ());
		Debug.Log(newEquipment.Intellect.ToString ());
	}
	
	public void CreateEquipment() {
		newEquipment = new BaseEquipment ();
		
		// Assign name to the equipment.
		newEquipment.ItemName = itemNames [Random.Range (0, itemNames.Length)] + " Equipment";
		
		// Create an equipment description.
		newEquipment.ItemDescription = itemDescriptions [Random.Range(0, itemDescriptions.Length)];
		
		// Set equipment ID.
		newEquipment.ItemID = Random.Range (1, 101);
				
		// Set equipment type.
		ChooseEquipmentType ();
		
		// Set equipment stats.
		newEquipment.Stamina = Random.Range (1, 11);
		newEquipment.Endurance = Random.Range (1, 11);
		newEquipment.Strength = Random.Range (1, 11);
		newEquipment.Intellect = Random.Range (1, 11);
		
		// Set spell effect ID.
		newEquipment.SpellEffectID = Random.Range (1, 101);
	}

	private void ChooseEquipmentType() {
		int randomTypeID = Random.Range (1, 9);
		if (randomTypeID == 1) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
		} else if (randomTypeID == 2) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERS;
		} else if (randomTypeID == 3) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
		} else if (randomTypeID == 4) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
		} else if (randomTypeID == 5) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
		} else if (randomTypeID == 6) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
		} else if (randomTypeID == 7) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.EARRING;
		} else if (randomTypeID == 8) {
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RING;
		}
	}
}
