using UnityEngine;
using System.Collections;

public class Price_speed : MonoBehaviour {
	public float scaleAdjust = 1.0f;
	private float scaleFix = 1.4f;
	int price;
	int UpgradeVal;

	// Use this for initialization
	void Start () {
		float _baseHeightInverted = 1.0f/Screen.width;
		float ratio = (Screen.height * _baseHeightInverted)*scaleFix*scaleAdjust;
		float ratiohalf = ratio*55/100;
		
		if (GetComponent<GUIText>()!=null)
		{
			GetComponent<GUIText>().pixelOffset = new Vector2(GetComponent<GUIText>().pixelOffset.x*ratio, Screen.height*9/16);
			GetComponent<GUIText>().fontSize = (int)(GetComponent<GUIText>().fontSize*ratiohalf);
		}
	}

	void Update() {
		UpgradeVal = PlayerPrefs.GetInt("speedUpgradeVal");
		if (UpgradeVal < 1){
			UpgradeVal = 0;
		}
		if (UpgradeVal == 0){
			price = 1500;
		}
		if (UpgradeVal == 1){
			price = 7500;
		}
		if (UpgradeVal == 2){
			price = 10000;
		}
		if (UpgradeVal == 3){
			price = 0;
		}

		GetComponent<GUIText>().text = "Coins: " + price;
	}
}
