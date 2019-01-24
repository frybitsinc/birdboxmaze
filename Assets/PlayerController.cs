using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb2d;
	private float speed = 2;
	//sound
	private AudioSource bumpSource;
	//player position
	public Transform player;
	// public Vector2 exitPos;
	private int mazeCol;
	private int mazeRow;
	//game clear
	public Transform clearCanvas;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		bumpSource = GetComponent<AudioSource> ();
		GameObject mazeGen = GameObject.Find("MazeGenerator");
		MazeGenerator mazeGenerator = mazeGen.GetComponent<MazeGenerator>();
		mazeCol = mazeGenerator.mazeColumns;
		mazeRow = mazeGenerator.mazeRows;
	}
	
	void FixedUpdate () {
		//Debug.Log((Vector2)player.transform.position);
		Vector2 playerPos = (Vector2)player.transform.position;
		if( Mathf.Abs(playerPos.x) >= (mazeCol/2) || Mathf.Abs(playerPos.y) >= (mazeRow/2)){
			//pause
			Time.timeScale = 0;
			//show clear menu
			clearCanvas.gameObject.SetActive(true);
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
