﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

	public static UiManager instance;

	public GameObject zigzagPanel;
	public GameObject gameOverPanel;
	public GameObject tapText;
	public Text score;
	public Text highscore1;
	public Text highscore2;

	void Awake() {
		if (instance == null) {
			instance = this;
		}
	}

	// Use this for initialization
	void Start () {
		highscore1.text = "High Score: " + PlayerPrefs.GetInt ("highScore");//.ToString ();
	}

	public void GameStart() {
		highscore1.text = PlayerPrefs.GetInt ("highScore").ToString();
		tapText.SetActive (false);
		zigzagPanel.GetComponent<Animator>().Play("panelUp");
	}

	public void GameOver() {
		score.text = PlayerPrefs.GetInt ("score").ToString();
		highscore2.text = PlayerPrefs.GetInt ("highScore").ToString();
		gameOverPanel.SetActive (true);
	}

	public void Reset() {
		SceneManager.LoadScene (0);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
