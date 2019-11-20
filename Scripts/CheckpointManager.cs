using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CheckpointManager : MonoBehaviour 
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
	public GameObject PointerDirector;
	public GameObject Pointer;
	public GameObject CheckPoint8;
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
		CheckPoint7.SetActive (false);
		CheckPoint8.SetActive (false);
	}
	public void Update()
	{
		if (CheckPointScript.noofcheckpoints == 0) 
		{
			PointerDirector.transform.position = CheckPoint1.transform.position;
			CheckPoint1.SetActive (true);
		}
		if (CheckPointScript.noofcheckpoints ==1) 
		{
			PointerDirector.transform.position = CheckPoint2.transform.position;
		CheckPoint1.SetActive (false);
			CheckPoint2.SetActive (true);
		}
		if (CheckPointScript.noofcheckpoints == 2) 
		{
			PointerDirector.transform.position = CheckPoint3.transform.position;
			CheckPoint2.SetActive (false);
			CheckPoint3.SetActive (true);
		}
		if (CheckPointScript.noofcheckpoints == 3) 
		{
			PointerDirector.transform.position = CheckPoint4.transform.position;
				CheckPoint3.SetActive (false);
			CheckPoint4.SetActive (true);
		}
		if (CheckPointScript.noofcheckpoints == 4) 
		{
			PointerDirector.transform.position = CheckPoint5.transform.position;
					CheckPoint4.SetActive (false);
			CheckPoint5.SetActive (true);
		}
		if (CheckPointScript.noofcheckpoints == 5) 
		{
			PointerDirector.transform.position = CheckPoint6.transform.position;
					CheckPoint5.SetActive (false);
			CheckPoint6.SetActive (true);
		}
		if (CheckPointScript.noofcheckpoints== 6) 
		{
			PointerDirector.transform.position = CheckPoint7.transform.position;
			CheckPoint6.SetActive (false);
			CheckPoint7.SetActive (true);
		}
		if (CheckPointScript.noofcheckpoints == 7) 
		{
			PointerDirector.transform.position = CheckPoint8.transform.position;
			CheckPoint7.SetActive (false);
			CheckPoint8.SetActive (true);
		}
		Pointer.transform.LookAt (PointerDirector.transform);
	}
}
