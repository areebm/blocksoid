using UnityEngine;
using System.Collections;

public class total_coins : MonoBehaviour {
	
	static int totalCoins = Coins.totalCoins;
	public float scaleAdjust = 1.0f;
	private float scaleFix = 1.4f;

	// Use this for initialization
	void Start () {
		totalCoins = PlayerPrefs.GetInt("totalCoins");

		float _baseHeightInverted = 1.0f/Screen.width;
		float ratio = (Screen.height * _baseHeightInverted)*scaleFix*scaleAdjust;
		float ratiohalf = ratio*3/4;
		
		if (GetComponent<GUIText>()!=null)
		{
			GetComponent<GUIText>().pixelOffset = new Vector2(GetComponent<GUIText>().pixelOffset.x*ratio, Screen.height*5/15);
			GetComponent<GUIText>().fontSize = (int)(GetComponent<GUIText>().fontSize*ratiohalf);
		}

		GetComponent<GUIText>().text = " " + totalCoins;
	}

}
