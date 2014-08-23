using UnityEngine;
using System.Collections;

/* EnemyScript - Controls an enemy character */
public class EnemyScript : MonoBehaviour {
	// Player - Search for and store the player so we can chase it
	private GameObject player;

	// Wander Command Script - Wander around aimlessly
	WanderCommandScript command;
	
	void Start() {
		command = new WanderCommandScript(this.gameObject);
		player = GameObject.FindGameObjectWithTag("Player");	// Make sure your player has the 'Player' tag!
		command.target = player;
	
	}
	
	void Update() {
		command.Execute();
	}
		
}
