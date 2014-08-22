using UnityEngine;
using System.Collections;

/* EnemyScript - Controls an enemy character */
public class EnemyScript : MonoBehaviour {

	// Movement Script - Used to execute character behavior
	private MoveScript moveScript;

	// Command Script - Execute a command
	CommandScript command;
	
	void Start() {
		moveScript = GetComponent<MoveScript>();

		command = new CommandScript(this.gameObject);
		Debug.Log (command.character.name);
	}
	
	void Update() {
		moveScript.Move (0, -1);	// Enemies should run straight down to start
	}
		
}
