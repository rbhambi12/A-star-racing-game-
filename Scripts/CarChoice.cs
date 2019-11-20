using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour 
{
	public GameObject BlueCar;
	public GameObject RedCar;
	public void Awake()
	{
		if (CarandTrackSelectionScript.CarColor == 1) {
			BlueCar.SetActive (true);	
		} 
		else if (CarandTrackSelectionScript.CarColor == 2)
		{
			RedCar.SetActive (true);
		}
	}	
}
