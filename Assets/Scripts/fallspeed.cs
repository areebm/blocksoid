using UnityEngine;
using System;
using System.Collections;

public class fallspeed : MonoBehaviour {

	float fallspeed1 = 1f;
	static int pausenum = OnButtonTouch.pausenum;

	// Prevents blocks from drifting sideways
	void Update () {
		pausenum = OnButtonTouch.pausenum;

		if (pausenum == 1) {
		fallspeed1 = fallspeed1 + 0.0001f;
//			float a = fallspeed1;
		float a = ((float)Math.Round(((double)fallspeed1),2));
		GetComponent<GUIText>().text = "" + a;
		}

		else {
			fallspeed1 = fallspeed1 + 0;
			float a = ((float)Math.Round(((double)fallspeed1),2));
			GetComponent<GUIText>().text = " " + a;
		}
	}
}
