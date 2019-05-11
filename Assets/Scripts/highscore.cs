using UnityEngine;
using System.Collections;

public class highscore : MonoBehaviour {

	public float scaleAdjust = 1.0f;
	private float scaleFix = 1.4f;

	void Start()
	{
		float _baseHeightInverted = 1.0f/Screen.width;
		float ratio = (Screen.height * _baseHeightInverted)*scaleFix*scaleAdjust;
		float ratiohalf = ratio*3/4;
		
		if (GetComponent<GUIText>()!=null)
		{
			GetComponent<GUIText>().pixelOffset = new Vector2(GetComponent<GUIText>().pixelOffset.x*ratio, Screen.height*7/15);
			GetComponent<GUIText>().fontSize = (int)(GetComponent<GUIText>().fontSize*ratiohalf);
		}

		int highscore1 = PlayerPrefs.GetInt("Highscore");
		GetComponent<GUIText>().text = " " + highscore1;
	}
}
