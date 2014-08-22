using UnityEngine;
using System.Collections;

/* EnemyScript - Controls an enemy character */
public class EnemyScript : MonoBehaviour {

	// Movement Script - Used to execute character behavior
	private MoveScript moveScript;
	
	void Start() {
		moveScript = GetComponent<MoveScript>();
	}
	
	void Update() {
		moveScript.Move (0, -1);	// Enemies should run straight down to start
	}
		
}
