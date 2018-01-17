using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour {
	public GameController gameController;
	private GameObject startButton;

	void Start(){
		startButton = GameObject.Find ("StartButton");
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.transform.tag == this.gameObject.tag && gameController.isStart){
			gameController.score++;
			Destroy (col.gameObject);
		}
		else{
			gameController.score = 0;
			gameController.isStart = false;
			startButton.SetActive (true);
		}
	}
}
