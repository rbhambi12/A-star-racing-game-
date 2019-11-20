using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStabilize : MonoBehaviour 
{
	public GameObject Car;
	public float X;
	public float Y;
	public float Z;
	public void Awake()
	{
		X = 0.0f;
		Y = 0.0f;
		Z = 0.0f;
	}
	public void Update()
	{
		X = Car.transform.eulerAngles.x;
		Y = Car.transform.eulerAngles.y;
		Z = Car.transform.eulerAngles.z;
		transform.eulerAngles = new Vector3 (X-X,Y,Z-Z);
	}
}
