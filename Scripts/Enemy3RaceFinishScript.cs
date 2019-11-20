using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;
using UnityEngine.AI;
public class Enemy3RaceFinishScript : MonoBehaviour 
{
	public GameObject enemycar3;
	public GameObject RaceFinishText;
	public void OnTriggerEnter(Collider other)
	{
if(other.gameObject.tag=="EnemyCar3")
{
this.gameObject.GetComponent<BoxCollider>().enabled=false;
enemycar3.GetComponent<CarAIControl>().enabled=false;
enemycar3.GetComponent<CarAIControlFinishRace> ().enabled = true;
			enemycar3.GetComponent<NavMeshAgent> ().enabled = false;
			enemycar3.GetComponent<PathFinding> ().enabled = false;

this.gameObject.GetComponent<BoxCollider>().enabled=true;
}		
	}	
	}
