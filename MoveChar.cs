using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChar : MonoBehaviour {

	public float speed;
	public float deadTime;

	void Start() {
		Destroy (gameObject, deadTime);
	}

	void Update () {
		transform.Translate (Vector2.left * speed);
	}
}
