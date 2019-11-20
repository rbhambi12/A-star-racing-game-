using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car; // We use this namespace to access CarAiControl.
using UnityEngine.AI;// We use this because NavMeshAgent is defined in it. 
public class Enemy2RaceFinishScript : MonoBehaviour // This class derives from Monobehaviour class
{
	public GameObject enemycar2;// Define two gameobjects enemycar2 and racefinishtext
	public GameObject RaceFinishText;
	public void OnTriggerEnter(Collider other) // This is an in built function which is automatically called whenever an object just begins touching the gameobject this script is attached to.
	// NOTE: A trigger is simply a collider in unity which actually does not stop movement of the object colliding with it through it.
	{
if(other.gameObject.tag=="EnemyCar2")// As mentioned earlier, GameObject is different from gameobject. "other.gameobject.tag" means if the tag of the gameobject of the car which collides with the gameobject this script is attached to is enemycar2
{
this.gameObject.GetComponent<BoxCollider>().enabled=false;// Disable the boxcollider of the gameobject this script is attached to.
			enemycar2.GetComponent<CarAIControl>().enabled=false;// Disable the carAIControl so that the car doesn't continue it's race.
enemycar2.GetComponent<CarAIControlFinishRace> ().enabled = true;// Enable the CarAIControlFinishRace which simply brakes the car and does nothing.
			enemycar2.GetComponent<NavMeshAgent> ().enabled = false; // Disable the NavMeshAgent attached to car otherwise the car will continue finding a path to it's next waypoint
			enemycar2.GetComponent<PathFinding> ().enabled = false; //Disable the PathFinding Script so that the car doesn't find a path to it's next waypoint.

this.gameObject.GetComponent<BoxCollider>().enabled=true; // Enable the box collider again.

}		
	}	
	}
