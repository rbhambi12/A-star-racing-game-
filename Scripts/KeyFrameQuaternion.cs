using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class KeyFrameQuaternion 
{
	public AnimationCurve curvex=new AnimationCurve();
	public AnimationCurve curvey=new AnimationCurve();
	public AnimationCurve curvez=new AnimationCurve();
	public AnimationCurve curvew=new AnimationCurve();
	public List <Keyframe> keysx=new List<Keyframe>();
	public List<Keyframe> keysy=new List<Keyframe>();
	public List<Keyframe> keysz=new List<Keyframe>();
	public List<Keyframe> keysw=new List<Keyframe>();
	public void AddkeyFrame(Quaternion value, float time)
		{
		keysx.Add (new Keyframe(time,value.x));
		keysy.Add (new Keyframe (time, value.y));
		keysz.Add (new Keyframe (time, value.z));
		keysw.Add (new Keyframe (time, value.w));
	}
	public void SetCurves()
	{
		curvex.keys = keysx.ToArray ();
		curvex=CurveUtilities.SetTangents (curvex, CurveTangentMode.smooth);
		curvey.keys = keysy.ToArray ();
		curvey=CurveUtilities.SetTangents (curvey, CurveTangentMode.smooth);
		curvez.keys = keysz.ToArray ();
		curvez=CurveUtilities.SetTangents (curvez, CurveTangentMode.smooth);
		curvew.keys = keysw.ToArray ();
		curvew = CurveUtilities.SetTangents (curvew, CurveTangentMode.smooth);
	}
	public void RemoveFramesAfterTime(float time)
	{
		int index = 0;
		for (int i = 0; i < keysx.Count; i++)
		{
			if (keysx [i].time > time) 
			{
				index = i;
				break;
			}

		}
		keysx.RemoveRange (index, keysx.Count - index);
	}
	public Quaternion SampleCurves(float time)
	{
		if (curvex.length > 0 && time > curvex.keys [curvex.keys.Length - 1].time)
		{
			time = curvex.keys [curvex.keys.Length - 1].time;
		}
		Quaternion quat = new Quaternion (curvex.Evaluate(time),curvey.Evaluate(time),curvez.Evaluate(time),curvez.Evaluate(time));
		return quat;
	}
}
