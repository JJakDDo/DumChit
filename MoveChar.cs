using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChar : MonoBehaviour {

	public float speed;
	public float deadTime;
	public GameController gameController;

	void Start() {
		Destroy (gameObject, deadTime);
		gameController = GameObject.Find ("GameController").GetComponent<GameController> ();
	}

	void Update () {
		transform.Translate (Vector2.left * speed);
		if(!gameController.isStart){
			Destroy (gameObject);
		}
	}
}
