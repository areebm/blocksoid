using UnityEngine;
using System.Collections;

public class text_play : MonoBehaviour {
	
//	public float scaleAdjust = 1.0f;
//	private float scaleFix = 1.4f;
//
//	void Start()
//	{
//		Time.timeScale = 1;
//		float _baseHeightInverted = 1.0f/Screen.width;
//		float ratio = (Screen.height * _baseHeightInverted)*scaleFix*scaleAdjust;
//		float ratiohalf = ratio*4/3;
//		
//		if (GetComponent<GUIText>()!=null)
//		{
//			GetComponent<GUIText>().pixelOffset = new Vector2(GetComponent<GUIText>().pixelOffset.x*ratio, GetComponent<GUIText>().pixelOffset.y*ratio + Screen.height*4/5);
//			GetComponent<GUIText>().fontSize = (int)(GetComponent<GUIText>().fontSize*ratiohalf);
//		}
//	}
	public void Update () {
		foreach (Touch touch in Input.touches){
			if (touch.phase == TouchPhase.Began && GetComponent<GUITexture>().HitTest(Input.touches[0].position)){
				AutoFade.LoadLevel ("Scene 2",1/5,1,Color.black);
			}
		}
	}
}