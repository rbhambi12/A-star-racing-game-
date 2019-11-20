using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraViewsScript : MonoBehaviour 
{
	public GameObject FrontCamera;
	public GameObject FollowCamera;
	public GameObject RightCamera;
	public GameObject LeftCamera;
	public int cameras = 1;
	public void Update()
	{
		if (Input.GetButtonDown ("Camera")) 
		{
			if (cameras == 4) {
				cameras = 1;
			}
			else
			{
				cameras = cameras + 1;	
		}
			StartCoroutine (CameraChange ());
		}		
	}
	public IEnumerator CameraChange()
	{
		yield return new WaitForSeconds (0.01f);
		if (cameras == 1) {
			FrontCamera.SetActive (true);
		FollowCamera.SetActive (false);
		}
		if (cameras == 2) {
			RightCamera.SetActive (true);
			FrontCamera.SetActive (false);
		}
		if (cameras == 3)
		{
			LeftCamera.SetActive (true);
		RightCamera.SetActive (false);
	}
		if (cameras == 4) {
			FollowCamera.SetActive (true);
			LeftCamera.SetActive (false);
		}

	}
}
