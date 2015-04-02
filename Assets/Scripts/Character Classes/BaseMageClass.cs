using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {

	public BaseMageClass() {
		CharacterClassName = "Mage";
		CharacterClassDescription = "A wise, spellcasting wizard.";
		Stamina = 12;
		Endurance = 14;
		Strength = 10;
		Intellect = 15;
	}
}
