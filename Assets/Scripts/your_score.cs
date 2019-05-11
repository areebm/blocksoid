using UnityEngine;
using System.Collections;

public class your_score : MonoBehaviour {

	public float scaleAdjust = 1.0f;
	private float scaleFix = 1.4f;

	void Start () {
		// Positioning text
		float _baseHeightInverted = 1.0f/Screen.width;
		float ratio = (Screen.height * _baseHeightInverted)*scaleFix*scaleAdjust;
		float ratiohalf = ratio*3/4;
		
		if (GetComponent<GUIText>()!=null)
		{
			GetComponent<GUIText>().pixelOffset = new Vector2(GetComponent<GUIText>().pixelOffset.x*ratio, Screen.height*3/15);
			GetComponent<GUIText>().fontSize = (int)(GetComponent<GUIText>().fontSize*ratiohalf);
		}

		GetComponent<GUIText>().text = " " + Score.score;
	}
}
