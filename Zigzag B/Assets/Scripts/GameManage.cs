using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManage : MonoBehaviour {

	public static GameManage instance;
	public bool gameOver;

	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame() {
		UiManager.instance.GameStart ();
		ScoreManager.instance.startScore ();

		GameObject.Find ("PlatformSpawners").GetComponent<PlatformSpawners> ().StartSpawningPlatforms ();

	}

	public void GameOver() {
		UiManager.instance.GameOver ();
		ScoreManager.instance.stopScore ();
		gameOver = true;
	}
}
