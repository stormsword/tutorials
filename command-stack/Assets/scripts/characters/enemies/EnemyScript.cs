using UnityEngine;
using System.Collections;

/* EnemyScript - Controls an enemy character */
public class EnemyScript : MonoBehaviour {

	[Tooltip("How close does a player have to be to aggro this enemy")]
	public float aggroRadius = 1.5f;

	// Player - Search for and store the player so we can chase it
	private GameObject player;
	private float playerDistance;

	// AI Scripts - Used to execute character behavior
	private CommandStackScript commands;
	
	void Start() {
		player = GameObject.FindGameObjectWithTag("Player");	// Make sure your player has the 'Player' tag!
		// Create stack of commands for AI behavior
		commands = new CommandStackScript();
	
	}
	
	void Update() {
		playerDistance = GetDistance(player);

		if (playerDistance >= aggroRadius) {
			// Chase the player
//			command.Execute();
		}
	}

	private float GetDistance(GameObject target) {
		return(Vector2.Distance(this.gameObject.transform.position, target.transform.position));
	}
		
}
