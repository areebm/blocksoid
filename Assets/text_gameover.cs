using UnityEngine;
using System.Collections;

public class text_gameover : MonoBehaviour {

//	public float scaleAdjust = 1.0f;
//	private float scaleFix = 1.4f;
	
//	void Start()
//	{
//		float _baseHeightInverted = 1.0f/Screen.width;
//		float ratio = (Screen.height * _baseHeightInverted)*scaleFix*scaleAdjust;
//		float ratiohalf = ratio;
//		
//		if (GetComponent<GUIText>()!=null)
//		{
//			GetComponent<GUIText>().pixelOffset = new Vector2(GetComponent<GUIText>().pixelOffset.x*ratio, Screen.height*5/15);
//			GetComponent<GUIText>().fontSize = (int)(GetComponent<GUIText>().fontSize*ratiohalf);
//		}
//	}

	void Update () {
		foreach (Touch touch in Input.touches){
		if (touch.phase == TouchPhase.Began && GetComponent<GUIText>().HitTest(Input.touches[0].position)){
			Application.LoadLevel ("Menu Temp");
		}
	}
	}
}
