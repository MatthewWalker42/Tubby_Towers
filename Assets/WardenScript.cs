using UnityEngine;
using System.Collections;

public class WardenScript : MonoBehaviour {
	protected GameObject playerT;
	protected GameObject enemyT;


	// Use this for initialization
	void Start () {

		playerT = GameObject.Find("PlaceholderPlayerTower");
		enemyT = GameObject.Find("PlaceholderEnemyTower");
	
	}
	
	// Update is called once per frame
	void Update () {

		if(playerT == null){
			//Debug.Log("You Died");
			Application.LoadLevel("GameOverMenu");
		}
		if(enemyT == null){
			Application.LoadLevel("VictoryMenu");
		}
	
	}
}
