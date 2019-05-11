using UnityEngine;
using System.Collections;

public class Audio_Manager : MonoBehaviour {

void Start() {
		DontDestroyOnLoad(this.gameObject);
		if (Application.loadedLevel == 1){
			GetComponent<AudioSource>().Play();
		}
	}
}