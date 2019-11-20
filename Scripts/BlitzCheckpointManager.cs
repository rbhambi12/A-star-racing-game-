using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlitzCheckpointManager : MonoBehaviour 
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
	public GameObject PointerDirector;
	public GameObject Pointer;
	public GameObject RaceFinishTrigger;
	public void Start()

	{
		Checkpoint.GetComponent<Text> ().text = "Checkpoint:";	
		totalnumberofcheckpoints = 6;
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
		if (CheckPointScriptBlitz.noofcheckpoints == 0) 
		{
			PointerDirector.transform.position = CheckPoint1.transform.position;
			CheckPoint1.SetActive (true);
		}
		if (CheckPointScriptBlitz.noofcheckpoints ==1) 
		{
			PointerDirector.transform.position = CheckPoint2.transform.position;
		CheckPoint1.SetActive (false);
			CheckPoint2.SetActive (true);
		}
		if (CheckPointScriptBlitz.noofcheckpoints == 2) 
		{
			PointerDirector.transform.position = CheckPoint3.transform.position;
			CheckPoint2.SetActive (false);
			CheckPoint3.SetActive (true);
		}
		if (CheckPointScriptBlitz.noofcheckpoints == 3) 
		{
			PointerDirector.transform.position = CheckPoint4.transform.position;
				CheckPoint3.SetActive (false);
			CheckPoint4.SetActive (true);
		}
		if (CheckPointScriptBlitz.noofcheckpoints == 4) 
		{
			PointerDirector.transform.position = CheckPoint5.transform.position;
					CheckPoint4.SetActive (false);
			CheckPoint5.SetActive (true);
		}
		if (CheckPointScriptBlitz.noofcheckpoints == 5) 
		{
			PointerDirector.transform.position = CheckPoint6.transform.position;
					CheckPoint5.SetActive (false);
			CheckPoint6.SetActive (true);
			if(!BlitzTimerScript.PlayerLostRace)
			RaceFinishTrigger.SetActive (true);
		}
		Pointer.transform.LookAt (PointerDirector.transform);
	}
}
