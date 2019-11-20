using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;
using UnityEngine.AI;
public class Enemy1RaceFinishScript : MonoBehaviour 
{
	public GameObject enemycar;
	public GameObject RaceFinishText;
	public void OnTriggerEnter(Collider other)
	{
if(other.gameObject.tag=="AICar")
{
this.gameObject.GetComponent<BoxCollider>().enabled=false;
enemycar.GetComponent<CarAIControl>().enabled=false;
enemycar.GetComponent<CarAIControlFinishRace> ().enabled = true;
enemycar.GetComponent<NavMeshAgent> ().enabled = false;
enemycar.GetComponent<PathFinding> ().enabled = false;

			this.gameObject.GetComponent<BoxCollider>().enabled=true;

}		
	}	
	}
