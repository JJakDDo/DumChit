using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour {

	public GameObject Player, PlayerPose1, PlayerPose2, PlayerPose3, PlayerPose4;
	public GameController gameController;
	private List<GameObject> PlayerPoses = new List<GameObject>();

	void Start(){
		GameObject pose1 = Instantiate (PlayerPose1) as GameObject;
		pose1.transform.position = Player.transform.position;
		PlayerPoses.Add (pose1);
		GameObject pose2 = Instantiate (PlayerPose2) as GameObject;
		pose2.transform.position = Player.transform.position;
		PlayerPoses.Add (pose2);
		GameObject pose3 = Instantiate (PlayerPose3) as GameObject;
		pose3.transform.position = Player.transform.position;
		PlayerPoses.Add (pose3);
		GameObject pose4 = Instantiate (PlayerPose4) as GameObject;
		pose4.transform.position = Player.transform.position;
		PlayerPoses.Add (pose4);

		showPose (0);
	}

	void Update(){
		showPose (gameController.poseNum); 
	}

	public void showPose(int n){
		for(int i=0;i<gameController.maxPose;i++){
			if (i == n)
				PlayerPoses [i].SetActive (true);
			else PlayerPoses [i].SetActive (false);
		}
	}
}
