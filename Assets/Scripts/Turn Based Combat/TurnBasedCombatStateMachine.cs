using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {

	public enum BattleStates {
		START,
		PLAYER_CHOICE,
		ENEMY_CHOICE,
		LOSE,
		WIN
	}
	private BattleStates currentState;

	// Use this for initialization.
	void Start () {
		currentState = BattleStates.START;
	}
	
	// Update is called once per frame.
	void Update () {
		Debug.Log (currentState);

		switch (currentState) {
		case(BattleStates.START):
			// Setup Battle function.
			break;
		case(BattleStates.PLAYER_CHOICE):
			break;
		case(BattleStates.ENEMY_CHOICE):
			break;
		case(BattleStates.LOSE):
			break;
		case(BattleStates.WIN):
			break;
		}
	}

	void OnGUI() {
		if (GUILayout.Button("Next state")) {
			if (currentState == BattleStates.START) {
				currentState = BattleStates.PLAYER_CHOICE;
			} else if (currentState == BattleStates.PLAYER_CHOICE) {
				currentState = BattleStates.ENEMY_CHOICE;
			} else if (currentState == BattleStates.ENEMY_CHOICE) {
				currentState = BattleStates.LOSE;
			} else if (currentState == BattleStates.LOSE) {
				currentState = BattleStates.WIN;
			} else if (currentState == BattleStates.WIN) {
				currentState = BattleStates.START;
			}
		}
	}
}
