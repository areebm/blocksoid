using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnButtonTouch : MonoBehaviour {

	public static int pausenum = 1;
	public Image Quit;
	public Image Paused;
	public static int quit;

	void Start () {
		pausenum = 1;
		if (Application.loadedLevel == 5){
			quit = 0;
		  Quit.color = new Vector4(1,1,1,0);
		  Paused.color = new Vector4(1,1,1,0);
		}
	}

	public void OnButtonDepress (string pressed){
		if(Application.loadedLevel == 5){ 
			quit = 1;
			AutoFade.LoadLevel(pressed, 1/4, 1/4, Color.black); 
		}
		else{
		AutoFade.LoadLevel(pressed, 1/4, 1/4, Color.black); 
		//( Level, fadeouttime, fadeintime, color)
		}
	}
	public void OnPauseDepress (){
			// Is game running?
			if (Time.timeScale == 1)
			{
				//Then pause
				Time.timeScale = 0;
				pausenum = 0;
			Quit.color = new Vector4(1,1,1,1);
			Paused.color = new Vector4(1,1,1,1);
			}
			//If game isn't running, start running
			else
			{
				Time.timeScale = 1;
				pausenum = 1;
			Quit.color = new Vector4(1,1,1,0);
			Paused.color = new Vector4(1,1,1,0);
			}
	}
}
