using UnityEngine;
using System.Collections;

public class lives : MonoBehaviour {

	public static int highscore;
	int total_lives;
	int UpgradeVallives;
	private static int totalCoins;
//	static int quit;


	void Start () {
		totalCoins = PlayerPrefs.GetInt("totalCoins");
		highscore = PlayerPrefs.GetInt("Highscore");
		UpgradeVallives = PlayerPrefs.GetInt("livesUpgradeVal");
			if (highscore < 1){
			highscore = 0;
			}

		if (UpgradeVallives < 1){
			total_lives = 0;
		}
		
		if (UpgradeVallives == 0){
			total_lives = 5;
		}
		if (UpgradeVallives == 1){
			total_lives = 10;
		}
		if (UpgradeVallives == 2){
			total_lives = 20;
		}
		if (UpgradeVallives == 3){
			total_lives = 30;
		}
	}

	// Update is called once per frame
	void Update () {

		// Checking lives count
		int lives = total_lives - (destroy_block_blue.block_lives_blue + destroy_block_red.block_lives_red);
//		int lives = total_lives;
		GetComponent<GUIText>().text = "Lives: " + lives;
		
		if (OnButtonTouch.quit == 1){
			Time.timeScale = 1;
			Application.LoadLevel("Menu Temp");
		}

		// When all lives are lost
		if (lives < 1){
			//highscore
			PlayerPrefs.SetInt("totalCoins", totalCoins + Score.score);
			if (Score.score > highscore)
			{
				highscore = Score.score;
				PlayerPrefs.SetInt("Highscore", highscore);
				PlayerPrefs.Save();
			}
			//game over screen
			AutoFade.LoadLevel ("GameOver",1/5,1,Color.black);
		}
	}
}
