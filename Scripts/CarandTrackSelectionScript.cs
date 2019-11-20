using System.Collections;
using System.Collections.Generic;
using UnityEngine;// Main namespace of the Unity game engine.
using UnityEngine.UI; // The DropDownList, Text etc are defined in UnityEngine.UI
public class CarandTrackSelectionScript : MonoBehaviour // CarAndtrackselectionscript class derives from the monobehaviour class.
{
	public static int CarColor;// 1=blue,2=red
	public GameObject TrackPanel;// Declaration of GameObjects named Trackpanel, track1, track2, track3, dropdow, label etc.
	public GameObject Track1;
	public GameObject Track2;
	public GameObject Track3;
	public GameObject DropDow;
	public GameObject Label;
	public GameObject Button1;
	public GameObject Button2;
	public GameObject Button3;
	public Dropdown drop; // Defining an object of Dropdown class
	public void RedCar() //An user defined function. Unity CANNOT call this automatically.
	{
		CarColor = 2;// assigning value of 2 to carcolor.
		Button1.SetActive(true);
		Button2.SetActive (true);
		Button3.SetActive (true);
	}	
	public void BlueCar() //Another user defined function. Cannot be called automatically. 
	{
		CarColor = 1;// Assigning value of 1 to carcolor.
		Button1.SetActive(true);
		Button2.SetActive (true);
		Button3.SetActive (true);
	}
	public void Awake()// Awake is called before Start by the unity engine and is called only once.
	{
		Label.GetComponent<Text> ().text = "Select Difficulty Level"; // The label of the dropdown is set to "Select difficulty level "
	}
	public void Valuechange(int x) // User defined function but is called from outside the script by the help of the unity engine.
	{
		if (x == 1) //if value of x, which is actually the index of the dropdownlist's selected item is one, then do the following
		{
			Track1.SetActive (true);// Show Track1
			Track2.SetActive (false);// Disable Track2
			Track3.SetActive (false);// Disable Track3
		}
		if (x == 2)// if value of x is 2, 	then do the following	{
		{			Track2.SetActive (true);// Show Track2
			Track1.SetActive (false);// Disable Track1
			Track3.SetActive (false);// Disable Track3
		}
		if (x == 3) // if value of x is 3 , then do the following. 
		{
			Track3.SetActive (true);// Show Track3
			Track1.SetActive (false); // Disable Track1 and Track2( in the next line)
			Track2.SetActive (false);
		}

	}
}
