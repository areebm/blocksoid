using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class quit_Active : MonoBehaviour {

	GameObject button;

	void Start(){
		button = GameObject.Find("Quit");
	}

	// Update is called once per frame
	void Update () {
		if(OnButtonTouch.pausenum == 1){
			button.GetComponent<Button>().interactable = false;
		}
		if(OnButtonTouch.pausenum == 0){
			button.GetComponent<Button>().interactable = true;
		}
	}
}
