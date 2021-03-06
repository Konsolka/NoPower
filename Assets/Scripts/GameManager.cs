﻿using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
	public float restartDelay = 2f;
	public GameObject	completeLevelUI;
	bool gameHasEnded = false;
	private void Start() {
		completeLevelUI.SetActive(false);
	}
	void endGame()
	{
		if (!gameHasEnded)
		{
			Debug.Log("GAME OVER");
			gameHasEnded = true;
			Invoke("Restart", restartDelay);
		}
	}
	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
	}
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
