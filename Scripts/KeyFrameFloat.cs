using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
/// <summary>
/// KeyFrameFloat
/// </summary>
public class KeyFrameFloat
{
public AnimationCurve curve=new AnimationCurve();
	public List <Keyframe> frame=new List<Keyframe>();
	public void AddKeyFrame(float value, float time)
	{
		frame.Add (new Keyframe (time, value));
	}
	public void SetCurves()
	{
		curve.keys = frame.ToArray ();		
		curve = CurveUtilities.SetTangents (curve, CurveTangentMode.smooth);
	}
	public float SampleCurves(float time)
	{
		if (curve.length > 0 && time > curve.keys [curve.keys.Length - 1].time)
		{
			time=curve.keys[curve.keys.Length-1].time;
		}
		float Float = curve.Evaluate (time);
		return Float;		
	}
}
