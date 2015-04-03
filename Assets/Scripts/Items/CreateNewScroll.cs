using UnityEngine;
using System.Collections;

public class CreateNewScroll : MonoBehaviour {

	private BaseScroll newScroll;

	// Use this for initialization.
	void Start () {
		CreateScroll ();
		Debug.Log(newScroll.ItemName);
		Debug.Log(newScroll.ItemDescription);
		Debug.Log(newScroll.ItemID.ToString ());
	}
	
	private void CreateScroll(){
		newScroll = new BaseScroll ();
		
		// Assign name to the scroll.
		newScroll.ItemName = "Scroll";
		
		// Create scroll description.
		newScroll.ItemDescription = "This is a powerful Scroll.";
		
		// Set scroll ID.
		newScroll.ItemID = Random.Range (1, 101);
		
		// Set spell effect ID.
		newScroll.SpellEffectID = Random.Range (1, 101);
	}
}
