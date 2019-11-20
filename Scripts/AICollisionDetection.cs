using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICollisionDetection : MonoBehaviour 
{
	public bool notdone;
	public void OnCollisionStay(Collision other)
	{
			StartCoroutine (Waiting ());
			Vector3 x = new Vector3 (0, 180, 0);
			if (!notdone)
				transform.Rotate (x);
			notdone = true;
			for (int i = 0; i < 5; i++) {
				StartCoroutine (Waiting ());
				notdone = false;
			}
		}
	public IEnumerator Waiting()
	{
		yield return new WaitForSeconds (1.0f);		
	}
}
