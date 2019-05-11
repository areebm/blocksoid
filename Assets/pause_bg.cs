using UnityEngine;
using System.Collections;

public class pause_bg : MonoBehaviour {

	static int pausenum = OnButtonTouch.pausenum;

	void Start () {
		GetComponent<GUITexture>().pixelInset = new Rect(0, 0, Screen.width, Screen.height);
	}

	void Update () {
		pausenum = OnButtonTouch.pausenum;
		if (pausenum == 1){
			GetComponent<GUITexture>().enabled = false;
		}
		else{
			GetComponent<GUITexture>().enabled = true;
		}
	}

}
