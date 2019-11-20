using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnim : MonoBehaviour 
{
	public GameObject Camera;
	public void Update()
	{
		Camera.transform.Rotate (0, 1, 0, Space.World);
	}
}
