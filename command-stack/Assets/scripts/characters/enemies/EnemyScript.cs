using UnityEngine;
using System.Collections;

/* EnemyScript - Controls an enemy character */
public class EnemyScript : MonoBehaviour {
	// Player - Search for and store the player so we can chase it
	private GameObject player;

	// Chase Command Script - Charge at an enemy
	ChaseCommandScript command;
	
	void Start() {
		Debug.Log (this.gameObject.name);
		command = new ChaseCommandScript(this.gameObject);
		player = GameObject.FindGameObjectWithTag("Player");	// Make sure your player has the 'Player' tag!
		command.target = player;
	
	}
	
	void Update() {
		command.Execute();
	}
		
}
