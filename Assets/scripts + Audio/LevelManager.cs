﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public bool IsGameOver { get; set;}

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}

	public void LoadNextScene()
	{
			int currentIndex = SceneManager.GetActiveScene ().buildIndex;
			SceneManager.LoadScene (currentIndex + 1);
	}

	public void QuitScene() {
	
		Application.Quit ();
	}

	public void RestartGame() {
		SceneManager.LoadScene (1);
	}
}