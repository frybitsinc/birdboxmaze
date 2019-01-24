using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clearScript : MonoBehaviour {
	public string MainScene;
	public string GameScene;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void BackToMain(){
		SceneManager.LoadScene(MainScene);
		Time.timeScale = 1;
	}

	public void Restart(){
		SceneManager.LoadScene(GameScene);
		Time.timeScale = 1;
	}
}
