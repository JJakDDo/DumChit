using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {
	public GameController gameController;

	public void startGame(){
		gameController.isStart = true;
		gameObject.SetActive (false);
	}
}
