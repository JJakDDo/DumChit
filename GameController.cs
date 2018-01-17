using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject PosePrefab1, PosePrefab2, PosePrefab3, PosePrefab4, PosePosition;
	public GameObject PoseChecker;
	public float PoseInterval = 2.0f;
	public int score = 0;
	public Text scoreText;
	private string[] pose = { "Pose1", "Pose2", "Pose3", "Pose4" };
	public int poseNum;
	public int maxPose = 4;
	private int randomPose;
	public bool isStart = false;

	void Start(){
		StartCoroutine ("CreateCharacter");
		poseNum = 0;
	}

	void Update(){
		scoreText.text = "SCORE: " + score;
	}

	IEnumerator CreateCharacter(){
		while(true){
			if(isStart){
				randomPose = Random.Range (0, maxPose);
				switch (randomPose){
				case 0:
					Instantiate (PosePrefab1, PosePosition.transform.position, Quaternion.identity);
					break;
				case 1:
					Instantiate (PosePrefab2, PosePosition.transform.position, Quaternion.identity);
					break;
				case 2:
					Instantiate (PosePrefab3, PosePosition.transform.position, Quaternion.identity);
					break;
				case 3:
					Instantiate (PosePrefab4, PosePosition.transform.position, Quaternion.identity);
					break;
				default:
					break;
				}			
			}
			yield return new WaitForSeconds (PoseInterval);	
		}
	}

	public void changePose(int i){
		if (i == 1){		
			poseNum++;	
			if (poseNum >= maxPose)
				poseNum = 0;
			PoseChecker.tag = pose[poseNum];
		} else if (i == -1) {
			poseNum--;	
			if (poseNum < 0)
				poseNum = maxPose - 1;
			PoseChecker.tag = pose[poseNum];
		}
	}
}
