using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BlitzCheckpointManagerRace03 : MonoBehaviour 
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
	public GameObject CheckPoint8;
	public GameObject CheckPoint9;
	public GameObject CheckPoint10;
	public GameObject CheckPoint11;
	public GameObject[] Trigger;
	public GameObject PointerDirector;
	public GameObject Pointer;
	public GameObject RaceFinishTrigger;
	public void Start()

	{
		Checkpoint.GetComponent<Text> ().text = "Checkpoint:";	
		totalnumberofcheckpoints = 11;
		numberofcheckpoints = 0;
		noofcheckpoints.GetComponent<Text> ().text = numberofcheckpoints.ToString ();
		totalnoofcheckpoints.GetComponent<Text> ().text = "/"+totalnumberofcheckpoints.ToString ();
		CheckPoint1.SetActive (false);
		CheckPoint2.SetActive (false);
		CheckPoint3.SetActive (false);
		CheckPoint4.SetActive (false);
		CheckPoint5.SetActive (false);
		CheckPoint6.SetActive (false);
		CheckPoint7.SetActive (false);
		CheckPoint8.SetActive (false);
		CheckPoint9.SetActive (false);
		CheckPoint10.SetActive (false);
		CheckPoint11.SetActive (false);

	}
	public void Update()
	{
		if (CheckPointScriptBlitzRace03.noofcheckpoints == 0) 
		{
			PointerDirector.transform.position = Trigger[0].transform.position;
			CheckPoint1.SetActive (true);
		}
		if (CheckPointScriptBlitzRace03.noofcheckpoints ==1) 
		{
			PointerDirector.transform.position = Trigger[1].transform.position;
			CheckPoint2.SetActive (true);
			CheckPoint1.SetActive (false);
		}
		if (CheckPointScriptBlitzRace03.noofcheckpoints == 2) 
		{
			PointerDirector.transform.position = Trigger[2].transform.position;
			CheckPoint3.SetActive (true);
			CheckPoint2.SetActive (false);
		}
		if (CheckPointScriptBlitzRace03.noofcheckpoints == 3) 
		{
			PointerDirector.transform.position = Trigger[3].transform.position;
			CheckPoint4.SetActive (true);
			CheckPoint3.SetActive (false);
		}
		if (CheckPointScriptBlitzRace03.noofcheckpoints == 4) 
		{
			PointerDirector.transform.position = Trigger[4].transform.position;
			CheckPoint5.SetActive (true);
			CheckPoint4.SetActive (false);
		}
		if (CheckPointScriptBlitzRace03.noofcheckpoints == 5) 
		{
			PointerDirector.transform.position = Trigger[5].transform.position;
			CheckPoint6.SetActive (true);
			CheckPoint5.SetActive (false);

		}
		if (CheckPointScriptBlitzRace03.noofcheckpoints == 6)
		{
			PointerDirector.transform.position = Trigger[6].transform.position;
			CheckPoint7.SetActive (true);
			CheckPoint6.SetActive (false);
		}
		if (CheckPointScriptBlitzRace03.noofcheckpoints == 7)
		{
			PointerDirector.transform.position = Trigger[7].transform.position;
			CheckPoint8.SetActive (true);
			CheckPoint7.SetActive (false);
		}
		if (CheckPointScriptBlitzRace03.noofcheckpoints == 8)
		{
			PointerDirector.transform.position = Trigger[8].transform.position;
			CheckPoint9.SetActive (true);
			CheckPoint8.SetActive (false);
		}
		if (CheckPointScriptBlitzRace03.noofcheckpoints == 9)
		{
			PointerDirector.transform.position = Trigger[9].transform.position;
			CheckPoint10.SetActive (true);
			CheckPoint9.SetActive (false);
		}
		if (CheckPointScriptBlitzRace03.noofcheckpoints == 10)
		{
			PointerDirector.transform.position = Trigger[10].transform.position;
			CheckPoint11.SetActive (true);
			CheckPoint10.SetActive (false);
			if(!BlitzTimerScriptRace03.PlayerLostRace)
				RaceFinishTrigger.SetActive (true);
		}

		Pointer.transform.LookAt (PointerDirector.transform);
	}
}
