using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb2d;
	private float speed = 2;
	//sound
	private AudioSource bumpSource;
	//player position
	public Transform player;
	//game clear
	public Transform clearCanvas;
	//user record
	public Text recordText;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		bumpSource = GetComponent<AudioSource> ();
	}
	
	void FixedUpdate () {
		//Debug.Log((Vector2)player.transform.position);
		Vector2 playerPos = (Vector2)player.transform.position;
		if( Mathf.Abs(playerPos.x) >= (MazeGenerator.mazeColumns/2) || Mathf.Abs(playerPos.y) >= (MazeGenerator.mazeRows/2)){
			//pause
			Time.timeScale = 0;
			//show clear menu
			clearCanvas.gameObject.SetActive(true);
			//set record
			//recordText.text = Timer.timerText.text;
		}
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
