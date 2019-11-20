using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1CompleteLapScript : MonoBehaviour 
{
	public GameObject HalfLapScripts;
	public GameObject LapCompleteScript;
	public GameObject RaceFinishScript;
	public int enemy1nooflaps=0;
	public void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag=="AICar")
		{		HalfLapScripts.SetActive (true);
			enemy1nooflaps += 1;
			if (enemy1nooflaps == 3) 
		{
			RaceFinishScript.SetActive (true);
		} 
		LapCompleteScript.SetActive (false);
	}
}
}