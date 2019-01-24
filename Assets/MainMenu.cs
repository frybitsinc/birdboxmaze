using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string newGameScene;
	public Dropdown dropdown;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NewGame(){
		Debug.Log("Dropdown Value: "+ dropdown.value);
		switch(dropdown.value){
			// EASY
			case 0:
				//4*4
				MazeGenerator.mazeRows = 4;
				MazeGenerator.mazeColumns = 4;
				break;
			// NORMAL
			case 1:
				//6*6
				MazeGenerator.mazeRows = 6;
				MazeGenerator.mazeColumns = 6;
				break;
			// HARD
			case 2:
				//8*8
				MazeGenerator.mazeRows = 8;
				MazeGenerator.mazeColumns = 8;
				break;
			// TORMENT
			case 3:
				//10*10
				MazeGenerator.mazeRows = 10;
				MazeGenerator.mazeColumns = 10;
				break;

		}
		SceneManager.LoadScene(newGameScene);
	}

	public void QuitGame(){
		Application.Quit();
	}
}
