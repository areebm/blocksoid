using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour {
	
	public Image tut1;
	public Image tut2;
	public Image tut3;
	public Image destroy;

	IEnumerator Start () { 
		tut1.color = new Vector4(1,1,1,0f);
		tut2.color = new Vector4(1,1,1, 0f); // Focus on the 0f -> it makes the image invisible
		tut3.color = new Vector4(1,1,1, 0f);
		destroy.color = new Vector4(1,1,1,0);
		yield return  new WaitForSeconds(2);
		tut1.color = new Vector4(1,1,1,1); // Show first instructions
		yield return new WaitForSeconds(4);
		tut1.color = new Vector4(1,1,1,0);
		tut2.color = new Vector4(1,1,1,1);// Fourth 0.988f brings the alpha value back up to make image visible again
		yield return new WaitForSeconds(3);
		tut2.color = new Vector4(1,1,1,0);
		tut3.color = new Vector4(1,1,1,1);
		yield return new WaitForSeconds(4);
		tut3.color = new Vector4(1,1,1,0);
		destroy.color = new Vector4(1,1,1,1);
		yield return new WaitForSeconds(3);
		destroy.color = new Vector4(1,1,1,0f);

		yield return new WaitForSeconds(15);
		AutoFade.LoadLevel ("Menu Temp",1/5,1,Color.black);
	}
}
