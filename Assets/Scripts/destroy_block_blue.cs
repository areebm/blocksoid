using UnityEngine;
using System.Collections;

public class destroy_block_blue : MonoBehaviour {

	private static float fallspeed = 1.5f;
	static int pausenum = OnButtonTouch.pausenum;
	public static int block_lives_blue;
	public static int block_score_blue;
	public GameObject Purple_Sparks;
	Vector3 pos;
	public static int level;

	// Start and Update
	//'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	
	// Initializes descent of blocks
	void Start () {
		transform.position = new Vector2(Random.Range(-3.4f,3.4f), Random.Range(9f,26f));
		fallspeed = 1f;
		block_lives_blue = 0;
		block_score_blue = 0;
	}

	void Update () {
		pausenum = OnButtonTouch.pausenum;
		if (pausenum == 1) {
			fallspeed = fallspeed + 0.0001f;
			if (fallspeed < 1.50){
				level = 1;
			}
			if (fallspeed >= 1.50 && fallspeed < 2.25){
				level = 2;
			}
			if (fallspeed >= 2.25 && fallspeed < 3.25){
				level = 3;
			}
			if (fallspeed >= 3.25 && fallspeed < 4){
				level = 4;
			}
			if (fallspeed >= 4 && fallspeed < 4.75){
				level = 5;
			}
			if (fallspeed >= 4.75){
				level = 6;
			}
		}
		else {
			fallspeed = fallspeed + 0;
		}
		GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -fallspeed);
	}


	// Upon collision with other objects 
	//'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


	// Sends blocks back up upon collision with Ground
	void OnTriggerEnter2D(Collider2D other) {
		transform.position = new Vector2(Random.Range(-3.4f,3.4f), Random.Range(9f,26f));
		GetComponent<Rigidbody2D>().velocity = new Vector2(0f,-fallspeed);
		block_lives_blue++;
	}

	// The ball hits this red block
	void OnCollisionEnter2D(Collision2D other){
		
		if (other.gameObject.CompareTag("Ball_Blue")){
			block_score_blue = (block_score_blue + 1*level);
			Destroy(other.gameObject);
			transform.position = new Vector2(Random.Range(-3.4f,3.4f), Random.Range(9f,26f));
		}

		if (other.gameObject.CompareTag("Ball_Red")){
			block_lives_blue++;
			Destroy(other.gameObject);
			Instantiate(Purple_Sparks, new Vector3(transform.position.x, transform.position.y, 5), Quaternion.identity);
			transform.position = new Vector2(Random.Range(-3.4f,3.4f), Random.Range(9f,26f));
			GetComponent<Rigidbody2D>().velocity = new Vector2(0f,-fallspeed);
		}

		else{
			transform.position = new Vector2(Random.Range(-3.4f,3.4f), Random.Range(9f,26f));
			GetComponent<Rigidbody2D>().velocity = new Vector2(0f,-fallspeed);
		}
	}
	
}
