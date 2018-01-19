using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
	public GameController gameController;
	public GameObject gameOverPanel;

	public void startGame(){
		gameController.isStart = true;
		gameObject.SetActive (false);
	}

	public void restartGame(){
		gameController.isStart = true;
		gameController.score = 0;
		gameOverPanel.SetActive (false);
	}
}
