using UnityEngine;
using System.Collections;

public class Total_coins_Upgrade : MonoBehaviour
{

		static int totalCoins = Coins.totalCoins;
		public float scaleAdjust = 1.0f;
		private float scaleFix = 1.4f;
	
		// Use this for initialization
		void Start ()
		{
				totalCoins = PlayerPrefs.GetInt ("totalCoins");
		
				float _baseHeightInverted = 1.0f / Screen.width;
				float ratio = (Screen.height * _baseHeightInverted) * scaleFix * scaleAdjust;
				float ratiohalf = ratio * 55 / 100;
		
				if (GetComponent<GUIText> () != null) {
						GetComponent<GUIText> ().pixelOffset = new Vector2 (GetComponent<GUIText> ().pixelOffset.x * ratio, Screen.height * 4 / 15);
						GetComponent<GUIText> ().fontSize = (int)(GetComponent<GUIText> ().fontSize * ratiohalf);
				}
		}

		void Update ()
		{
				totalCoins = PlayerPrefs.GetInt ("totalCoins");
				GetComponent<GUIText>().text = " " + totalCoins;
		}
}
