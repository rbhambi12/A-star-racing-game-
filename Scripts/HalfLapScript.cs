using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLapScript : MonoBehaviour 
{
	public GameObject HalfLapTrig;
	public GameObject LapCompleteTrig;
	public static bool playercompletedhalf;
	public bool internalplayer;
	public bool enemy1completedhalf;
	public bool enemy2completedhalf;
	public bool enemy3completedhalf;
	public bool enemy4completedhalf;
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			playercompletedhalf =true;
			internalplayer = playercompletedhalf;
			LapCompleteTrig.SetActive (true);
			HalfLapTrig.SetActive (false);
		}
	
	}	
}
