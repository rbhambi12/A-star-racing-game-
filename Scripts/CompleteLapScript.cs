using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLapScript : MonoBehaviour 
{
	public GameObject HalfLapScripts;
	public GameObject LapCompleteScript;
	public GameObject RaceFinishScript;
	public GameObject laptime;
	public GameObject CheckPoint1;
	public GameObject CheckPoint2;
	public GameObject CheckPoint3;
	public GameObject CheckPoint4;
	public GameObject CheckPoint5;
	public GameObject CheckPoint6;
	public GameObject CheckPoint7;
	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{	
			LapPanelManager.numberoflaps += 1;
			if (LapPanelManager.numberoflaps == 3)
			{
				RaceFinishScript.SetActive (true);
				laptime.SetActive (false);
			} 
			else {
				HalfLapScripts.SetActive (true);
				HalfLapScript.playercompletedhalf = false;
				LapCompleteScript.SetActive (false);
				LapTimeManager.minute = 0;
				LapTimeManager.second = 0;
				LapTimeManager.millisecond = 0;
				CheckPointScript.noofcheckpoints = 0;
				CheckPoint1.SetActive (true);
				CheckPoint2.SetActive (true);
				CheckPoint3.SetActive (true);
				CheckPoint4.SetActive (true);
				CheckPoint5.SetActive (true);
				CheckPoint6.SetActive (true);
				CheckPoint7.SetActive (true);
			}
		}
		if (other.gameObject.tag == "AICar") 
		{
			CheckPointScript.enemynoofcheckpoints = 0;
		}
		if (other.gameObject.tag == "EnemyCar2") 
		{
			CheckPointScript.enemy2noofcheckpoints = 0;
		}
		if(other.gameObject.tag=="EnemyCar3")
		{
			CheckPointScript.enemy3noofcheckpoints = 0;
		}
		if(other.gameObject.tag=="EnemyCar4")
		{
			CheckPointScript.enemy4noofcheckpoints = 0;
		}

	}
}
