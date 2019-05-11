using UnityEngine;
using System.Collections;

public class SplashScreenDelayed : MonoBehaviour {
	
	IEnumerator Start () {
		yield return new WaitForSeconds(3/2);
		AutoFade.LoadLevel("Menu Temp", 1, 1/2, Color.black);
	}
}
