using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public static int score;
	
	 //Update is called once per frame
	void Update () {
		score = destroy_block_blue.block_score_blue + destroy_block_red.block_score_red;
		GetComponent<GUIText>().text = "Score: " + score;
//		if (destroy_block_blue.level == 1){guiText.text = "Score " + score;}
//		if (destroy_block_blue.level == 2){guiText.text = " " + score;}
//		if (destroy_block_blue.level == 3){guiText.text = " " + score;}
//		if (destroy_block_blue.level == 4){guiText.text = " " + score;}
//		if (destroy_block_blue.level == 5){guiText.text = " " + score;}
//		if (destroy_block_blue.level == 6){guiText.text = " " + score;}
	}
}
