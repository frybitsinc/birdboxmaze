using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScript : MonoBehaviour {
	public Transform canvas;
// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(canvas.gameObject.activeInHierarchy == false){
				Time.timeScale = 0;
				canvas.gameObject.SetActive(true);
			}
			else{
				Time.timeScale = 1;
				canvas.gameObject.SetActive(false);
			}
		}
	}
	
}
