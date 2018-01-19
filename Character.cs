using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour {
	public GameController gameController;
	public GameObject gameOverPanel;

	void OnTriggerEnter2D(Collider2D col){
		if(col.transform.tag == this.gameObject.tag && gameController.isStart){
			gameController.score++;
			Destroy (col.gameObject);
		}
		else{
			gameController.setHighScore ();
			gameController.isStart = false;
			gameOverPanel.SetActive (true);
		}
	}
}
