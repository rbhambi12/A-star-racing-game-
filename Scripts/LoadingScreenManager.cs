using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LoadingScreenManager : MonoBehaviour 
{
	public GameObject LoadingScreenText;
	public void Awake()
	{
		LoadingScreenText.GetComponent<Text> ().text = "Loading Game...";		
	}

}
