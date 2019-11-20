using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScreen : MonoBehaviour 
{
	public GameObject FadeScreen01;
	public void Start()
	{
		StartCoroutine (FadingScreen());
	}	
	public IEnumerator FadingScreen()
	{
		FadeScreen01.GetComponent<Animator> ().enabled = true;
		yield return new WaitForSeconds (2.0f);
		FadeScreen01.GetComponent<Animator> ().enabled = false;
	}
}
