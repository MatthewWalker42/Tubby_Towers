﻿using UnityEngine;
using System.Collections;

public class PlaceholderPlayerTower : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		for (int i=0; i<1; i++) {
			StartCoroutine(WaitSecond());


		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateUnit(){
		GameObject newFighter = (GameObject) Instantiate (Resources.Load ("Placeholder/PlaceholderPlayerFighter"));
		newFighter.transform.position = new Vector2(-33, -2);
		}

	IEnumerator WaitSecond(){

		for (int i = 0; i < 3; i++) {
						CreateUnit ();
						yield return new WaitForSeconds (3.0f);
				}
		//CreateUnit ();
		}
}
