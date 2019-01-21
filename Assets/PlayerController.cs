using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb2d;
	private float speed = 2;
	//sound
	private AudioSource bumpSource;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		bumpSource = GetComponent<AudioSource> ();
	}
	
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
		rb2d.velocity = movement * speed;
	}

	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "Wall") {
			if (col.relativeVelocity.magnitude > 1){
				bumpSource.Play();
			}
		}
		// print("collision detected. play sound. ");
		// Destroy(collision.gameObject);
	}
}
