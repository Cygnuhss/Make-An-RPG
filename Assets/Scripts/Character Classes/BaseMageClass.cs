using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {

	public void MageClass() {
		CharacterClassName = "Mage";
		CharacterClassDescription = "A wise, spellcasting wizard.";
		Stamina = 12;
		Endurance = 14;
		Strength = 10;
		Intellect = 15;
	}
}
