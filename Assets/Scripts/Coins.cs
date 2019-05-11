using UnityEngine;
using System.Collections;

public class Coins : MonoBehaviour {

	public static int numCoins;
	public static int totalCoins;
	public float scaleAdjust = 1.0f;
	private float scaleFix = 1.4f;



	// Use this for initialization
	void Start () {
		// Get Total Coins
		totalCoins = PlayerPrefs.GetInt("totalCoins");
		if (totalCoins < 1){
			totalCoins = 0;
		}

		// Position "Coins:" text
		float _baseHeightInverted = 1.0f/Screen.width;
		float ratio = (Screen.height * _baseHeightInverted)*scaleFix*scaleAdjust;
		float ratiohalf = ratio*3/4;
			
		if (GetComponent<GUIText>()!=null)
		{
			GetComponent<GUIText>().pixelOffset = new Vector2(GetComponent<GUIText>().pixelOffset.x*ratio, Screen.height*1/15);
			GetComponent<GUIText>().fontSize = (int)(GetComponent<GUIText>().fontSize*ratiohalf);
		}
	}

		void Update () {

		// Get score from this round
			
//			int blue_score = check_tag_blue.blue_score;
//			int red_score = check_tag_red.red_score;
//			int red_score2 = Check_tag_redL.red_score2;
//			int score = blue_score + red_score+ red_score2;
		
		// Get new score and add it to numCoins
		int numCoins = Score.score;
		PlayerPrefs.SetInt("totalCoins", totalCoins + numCoins);
		PlayerPrefs.Save();

		// Display new coins
		GetComponent<GUIText>().text = "New Coins: " + Score.score;
		}
}
