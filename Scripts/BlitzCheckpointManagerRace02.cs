using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlitzCheckpointManagerRace02 : MonoBehaviour 
{
	public GameObject Checkpoint;
	public int totalnumberofcheckpoints;
	public int numberofcheckpoints;
	public GameObject noofcheckpoints;
	public GameObject totalnoofcheckpoints;
	public GameObject CheckPoint1;
	public GameObject CheckPoint2;
	public GameObject CheckPoint3;
	public GameObject CheckPoint4;
	public GameObject CheckPoint5;
	public GameObject CheckPoint6;
	public GameObject CheckPoint7;
	public GameObject[] Trigger;
	public GameObject PointerDirector;
	public GameObject Pointer;
	public GameObject RaceFinishTrigger;
	public void Start()

	{
		Checkpoint.GetComponent<Text> ().text = "Checkpoint:";	
		totalnumberofcheckpoints = 7;
		numberofcheckpoints = 0;
		noofcheckpoints.GetComponent<Text> ().text = numberofcheckpoints.ToString ();
		totalnoofcheckpoints.GetComponent<Text> ().text = "/"+totalnumberofcheckpoints.ToString ();
		CheckPoint1.SetActive (false);
		CheckPoint2.SetActive (false);
		CheckPoint3.SetActive (false);
		CheckPoint4.SetActive (false);
		CheckPoint5.SetActive (false);
		CheckPoint6.SetActive (false);
	}
	public void Update()
	{
		if (CheckPointScriptBlitzRace02.noofcheckpoints == 0) 
		{
			PointerDirector.transform.position = Trigger[0].transform.position;
			CheckPoint1.SetActive (true);
		}
		if (CheckPointScriptBlitzRace02.noofcheckpoints ==1) 
		{
			PointerDirector.transform.position = Trigger[1].transform.position;
			CheckPoint2.SetActive (true);
			CheckPoint1.SetActive (false);
		}
		if (CheckPointScriptBlitzRace02.noofcheckpoints == 2) 
		{
			PointerDirector.transform.position = Trigger[2].transform.position;
			CheckPoint3.SetActive (true);
			CheckPoint2.SetActive (false);
		}
		if (CheckPointScriptBlitzRace02.noofcheckpoints == 3) 
		{
			PointerDirector.transform.position = Trigger[3].transform.position;
			CheckPoint4.SetActive (true);
			CheckPoint3.SetActive (false);
		}
		if (CheckPointScriptBlitzRace02.noofcheckpoints == 4) 
		{
			PointerDirector.transform.position = Trigger[4].transform.position;
			CheckPoint5.SetActive (true);
			CheckPoint4.SetActive (false);
		}
		if (CheckPointScriptBlitzRace02.noofcheckpoints == 5) 
		{
			PointerDirector.transform.position = Trigger[5].transform.position;
			CheckPoint6.SetActive (true);
			CheckPoint5.SetActive (false);

		}
		if (CheckPointScriptBlitzRace02.noofcheckpoints == 6)
		{
			PointerDirector.transform.position = Trigger[6].transform.position;
			CheckPoint7.SetActive (true);
			CheckPoint6.SetActive (false);
			if(!BlitzTimerScriptRace02.PlayerLostRace)
				RaceFinishTrigger.SetActive (true);
		}
		Pointer.transform.LookAt (PointerDirector.transform);
	}
}
