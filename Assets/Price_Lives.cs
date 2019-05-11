using UnityEngine;
using System.Collections;

public class Price_Lives : MonoBehaviour {
	public float scaleAdjust = 1.0f;
	private float scaleFix = 1.4f;
	int price;
	int UpgradeVallives;
	
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
	
	// Update is called once per frame
	void Update () {
		UpgradeVallives = PlayerPrefs.GetInt("livesUpgradeVal");
		if (UpgradeVallives < 1){
			UpgradeVallives = 0;
		}
		if (UpgradeVallives == 0){
			price = 1500;
		}
		if (UpgradeVallives == 1){
			price = 7500;
		}
		if (UpgradeVallives == 2){
			price = 10000;
		}
		if (UpgradeVallives == 3){
			price = 0;
		}
		
		GetComponent<GUIText>().text = "Coins: " + price;
	}
}
