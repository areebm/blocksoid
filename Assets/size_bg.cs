using UnityEngine;
using System.Collections;

public class size_bg : MonoBehaviour {

	static int pausenum = OnButtonTouch.pausenum;
	public Rigidbody2D Blue_Bullet;
	public Rigidbody2D Red_Bullet;
	public GameObject Blue_Sparks;
	public GameObject Red_Sparks;
	float y_blue;
	float y_red;

	void Update() {
		pausenum = OnButtonTouch.pausenum;
		if (pausenum == 1){
			foreach (Touch touch in Input.touches){
				if (touch.phase == TouchPhase.Began){
					y_blue = touch.position.y;
					y_red = touch.position.y;
					if (touch.position.x > Screen.width/2+50 && touch.position.y < Screen.height - 145){
					Instantiate(Blue_Bullet, Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, y_blue, 5)), Quaternion.identity);
						Instantiate(Blue_Sparks, Camera.main.ScreenToWorldPoint(new Vector3(Screen.width+Screen.width*1/15, y_blue, 5)), Quaternion.identity);
						GetComponent<AudioSource>().Play();
						//Instantiates blue at previous cannon position
					}
					if (touch.position.x < Screen.width/2-50 && touch.position.y < Screen.height - 145){
						Instantiate(Red_Bullet, Camera.main.ScreenToWorldPoint(new Vector3(Screen.width- Screen.width*15/14, y_red, 5)), Quaternion.identity);
						Instantiate(Red_Sparks, Camera.main.ScreenToWorldPoint(new Vector3(Screen.width-Screen.width*15/14, y_red, 5)), Quaternion.identity);
						GetComponent<AudioSource>().Play();
						//Added Red instantiation point on Y
					}
				}
			}
		}
	}
}
