using UnityEngine;
using System.Collections;

public class Check_tag_redL : MonoBehaviour {

	int shootspeed;
	int UpgradeVal;

	// Give instantiated ball a velocity into scene
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
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(shootspeed,0);
	}

	//If ball drifts up or down, destroy it
//	void Updtae() {
//		if (rigidbody2D.velocity.y >= 0){
//			Destroy(gameObject);
//		}
//	}

	// If it hits a boundary, destroys itself
	void OnTriggerEnter2D(Collider2D other) {
		Destroy(gameObject);
	}

	// If it hits a block, destroys itself, sends block back up
	void OnCollisionEnter2D(Collision2D other){
		Destroy(gameObject);
		Destroy(other.gameObject);
	}
}
