using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum CurvetangentMode
{
smooth,
stepped
}
public class CurveUtility:MonoBehaviour
{
	public static Vector3[] smoothLinePoints(Vector3[] inputpoints,float segmentsize)
	{
		AnimationCurve curvex = new AnimationCurve ();
		AnimationCurve curvey = new AnimationCurve ();
		AnimationCurve curvez = new AnimationCurve ();
		Keyframe[] keysx = new Keyframe[inputpoints.Length];
		Keyframe[] keysy=new Keyframe[inputpoints.Length];
		Keyframe[] keysz = new Keyframe[inputpoints.Length];
		for (int i = 0; i < inputpoints.Length; i++) 
		{
			keysx [i] = new Keyframe (i, inputpoints [i].x);
			keysy [i] = new Keyframe (i, inputpoints [i].y);
			keysz [i] = new Keyframe (i, inputpoints [i].z);
		}
		curvex.keys = keysx;
			curvey.keys = keysy;
			curvez.keys = keysz;
		
		for(int i=0;i<inputpoints.Length;i++)
			{
			curvex.SmoothTangents (i, 0);
			curvey.SmoothTangents (i, 0);
			curvez.SmoothTangents (i, 0);
		}
		List<Vector3> linesegments = new List<Vector3> ();
		for (int i = 0; i < inputpoints.Length; i++)
		{
			linesegments.Add (inputpoints [i]);
			if (i + 1 < inputpoints.Length) 
			{
				float distancetonext = Vector3.Distance (inputpoints [i], inputpoints [i + 1]);
				int segments = (int)(distancetonext / segmentsize);
				for (int s = 1; s < segments; s++) 
				{
					float time = ((float)s / (float)segments) + (float)i;
					Vector3 newsegment = new Vector3 (curvex.Evaluate (time), curvey.Evaluate (time), curvez.Evaluate (time));
					linesegments.Add (newsegment);
				}
			}

		}
		return linesegments.ToArray ();
	}
	public static AnimationCurve[] SmoothLinecurveTime01(Vector3[] inputPoints)
	{
		AnimationCurve curvex = new AnimationCurve ();
		AnimationCurve curvey = new AnimationCurve ();
		AnimationCurve curvez = new AnimationCurve ();
		Keyframe[] keysx = new Keyframe[inputPoints.Length];
		Keyframe[] keysy = new Keyframe[inputPoints.Length];
		Keyframe[] keysz = new Keyframe[inputPoints.Length];
		for (int i = 0; i < inputPoints.Length; i++)
		{
			float time = (float)i / ((float)inputPoints.Length - 1);
			keysx [i] = new Keyframe (time, inputPoints [i].x);
			keysy [i] = new Keyframe (time, inputPoints [i].y);
			keysz [i] = new Keyframe (time, inputPoints [i].z);
		}
		curvex.keys = keysx;
		curvey.keys = keysy;
		curvez.keys = keysz;
		for (int i = 0; i < inputPoints.Length; i++) 
		{
			curvex.SmoothTangents (i, 0);
			curvey.SmoothTangents (i, 0);
			curvez.SmoothTangents (i, 0);
		}
		AnimationCurve[] packedcurves=new AnimationCurve[3];
		packedcurves [0] = curvex;
		packedcurves [1] = curvey;
		packedcurves [2] = curvez;
		return packedcurves;
	}
	public static AnimationCurve SetTangents(AnimationCurve curve, CurvetangentMode tangentMode)
	{
		for (int i = 0; i < curve.keys.Length; i++)
		{
			if (tangentMode == CurvetangentMode.smooth) 
			{
				curve.SmoothTangents (i, 0);
			}
			if (tangentMode == CurvetangentMode.stepped) 
			{
				curve.keys [i].inTangent = Mathf.Infinity;
				curve.keys [i].outTangent = Mathf.Infinity;
			}
		}
		return curve;
	}
}