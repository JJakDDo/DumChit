using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePoseButton : MonoBehaviour {
	public GameController gameController;

	public void OnClick(){
		if(this.gameObject.tag.Equals ("Right")){
			gameController.changePose (1);
		}
		else if(this.gameObject.tag.Equals ("Left")){
			gameController.changePose (-1);			
		}
	}
}
