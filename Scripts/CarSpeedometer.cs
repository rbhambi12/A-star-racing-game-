using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpeedometer : MonoBehaviour {

	const float MAX_SPEED = 240f;

	public Transform arrow;


	static float minAngle = 116f;
	static float maxAngle = -117f;

	public void ShowArrowAngle(float currentSpeed)
	{
		if (arrow != null) {
			float ang = Mathf.Lerp(minAngle, maxAngle, Mathf.InverseLerp(0, MAX_SPEED, currentSpeed));
			arrow.eulerAngles = new Vector3 (0, 0, ang);
		}

	}

}
