using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class Multiplier : MonoBehaviour {

//	int level = destroy_block_blue.level;
	int pausenum = OnButtonTouch.pausenum;
	public Image x2;
	public Image x3;
	public Image x4;
	public Image x5;
	public Image x6;

	void Start() {
	x2.color = new Vector4(1,1,1,0f);
	x3.color = new Vector4(1,1,1,0f);
	x4.color = new Vector4(1,1,1,0f);
	x5.color = new Vector4(1,1,1,0f);
	x6.color = new Vector4(1,1,1,0f);
	}

	// Prevents blocks from drifting sideways
	void Update(){
	pausenum = OnButtonTouch.pausenum;
	if (pausenum == 1) {

		if (destroy_block_blue.level == 2){
			x2.color = new Vector4(1,1,1,1f);
		}
		if (destroy_block_blue.level == 3){
			x2.color = new Vector4(1,1,1,0f);
			x3.color = new Vector4(1,1,1,1f);
		}
		if (destroy_block_blue.level == 4){
			x3.color = new Vector4(1,1,1,0f);
			x4.color = new Vector4(1,1,1,1f);
		}
		if (destroy_block_blue.level == 5){
			x4.color = new Vector4(1,1,1,0f);
			x5.color = new Vector4(1,1,1,1f);
		}
		if (destroy_block_blue.level == 6){
			x5.color = new Vector4(1,1,1,0f);
			x6.color = new Vector4(1,1,1,1f);
		}
	}
  }
}
