using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Records Vector3 frames for playback.
/// </summary>
public class KeyFrameVector3
{
	public AnimationCurve x=new AnimationCurve();
	public AnimationCurve y=new AnimationCurve();
	public AnimationCurve z = new AnimationCurve ();
	public List<Keyframe> keysx=new List<Keyframe>();
	public List<Keyframe> keysy=new List<Keyframe>();
	public List<Keyframe> keysz=new List<Keyframe>();
	public void AddKeyFrame(Vector3 value, float time)
	{
		keysx.Add (new Keyframe (time, value.x));
		keysy.Add (new Keyframe (time, value.y));
		keysz.Add (new Keyframe (time, value.z));
	}
	public void SetCurves()
	{
		x.keys = keysx.ToArray ();	
		CurveUtilities.SetTangents (x,CurveTangentMode.smooth);
		y.keys = keysy.ToArray ();
		CurveUtilities.SetTangents (y, CurveTangentMode.smooth);
		z.keys = keysz.ToArray ();
		CurveUtilities.SetTangents (z, CurveTangentMode.smooth);
	}
	public Vector3 SampleCurves (float time)
	{
		if(x.length>0&&time>x.keys[x.keys.Length-1].time)
		{
			time = x.keys [x.keys.Length - 1].time;
		}
		Vector3 vec3 = new Vector3 (x.Evaluate(time),y.Evaluate(time),z.Evaluate(time));
		return vec3;

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
}
