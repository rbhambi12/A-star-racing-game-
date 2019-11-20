using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;
using UnityEngine.AI;
public class Enemy4RaceFinishScript : MonoBehaviour 
{
	public GameObject enemycar4;
	public GameObject RaceFinishText;
	public void OnTriggerEnter(Collider other)
	{
if(other.gameObject.tag=="EnemyCar4")
{
this.gameObject.GetComponent<BoxCollider>().enabled=false;
enemycar4.GetComponent<CarAIControl>().enabled=false;
enemycar4.GetComponent<CarAIControlFinishRace> ().enabled = true;
			enemycar4.GetComponent<NavMeshAgent> ().enabled = false;
			enemycar4.GetComponent<PathFinding> ().enabled = false;

this.gameObject.GetComponent<BoxCollider>().enabled=true;

}		
	}	
	}
