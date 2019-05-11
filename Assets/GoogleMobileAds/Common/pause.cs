using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {

	public static int pausenum = 1;

	void Start () {
		GetComponent<GUITexture>().pixelInset = new Rect(Screen.width/2-(95/2), Screen.height - 145, 125, 125);
		pausenum = 1;
	}

	void Update () {
		foreach (Touch touch in Input.touches){
			if (touch.phase == TouchPhase.Began && GetComponent<GUITexture>().HitTest(Input.touches[0].position)){
				// Is game running?
			if (Time.timeScale == 1)
			{
					//Then pause
				Time.timeScale = 0;
				pausenum = 0;
			}
				//If you touch and the game isn't running, start running
			else
			{
				Time.timeScale = 1;
				pausenum = 1;
			}
		}
	}
}
}