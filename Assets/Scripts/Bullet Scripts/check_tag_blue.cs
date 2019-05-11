using UnityEngine;
using System.Collections;

public class check_tag_blue : MonoBehaviour {

	int UpgradeVal;
	int shootspeed;

	void Start () {
		UpgradeVal = PlayerPrefs.GetInt("speedUpgradeVal");
		if (UpgradeVal == 0){
			shootspeed = 8;
		}
		if (UpgradeVal == 1){
			shootspeed = 12;
		}
		if (UpgradeVal == 2){
			shootspeed = 17;
		}
		if (UpgradeVal == 3){
			shootspeed = 21;
		}
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-(shootspeed),0);
	}

	//If ball drifts up or down, destroy it
//	void Update() {
//		if (rigidbody2D.velocity.x <= 2){
//			Destroy(gameObject);
//		}
//	}
	
	// If it hits a boundary, destroys itself
	void OnTriggerEnter2D(Collider2D other) {
		Destroy(gameObject);
	}
	
	// If it hits another game object, destroys itself, sends block back up
	void OnCollisionEnter2D(Collision2D other){
		Destroy(gameObject);
		Destroy(other.gameObject);
	}
}
