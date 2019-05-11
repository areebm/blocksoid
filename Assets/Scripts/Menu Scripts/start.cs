using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

	public float scaleAdjust = 1.0f;
	private float scaleFix = 1.4f;
	
	void Start()
	{
		float _baseHeightInverted = 1.0f/Screen.width;
		float ratio = (Screen.height * _baseHeightInverted)*scaleFix*scaleAdjust;
		float ratiohalf = ratio*1/2;
		
		if (GetComponent<GUIText>()!=null)
			{
				GetComponent<GUIText>().pixelOffset = new Vector2(GetComponent<GUIText>().pixelOffset.x*ratio, GetComponent<GUIText>().pixelOffset.y*ratio + Screen.height*3/4);
				GetComponent<GUIText>().fontSize = (int)(GetComponent<GUIText>().fontSize*ratiohalf);
			}
	}

	void Update () {
		if (Input.touches.Length > 0 && GetComponent<GUIText>().HitTest(Input.touches[0].position)){
			GUI.color = Color.yellow;
			AutoFade.LoadLevel ("Scene 1",1/5,2,Color.black);
		}
	}
}