using UnityEngine;
using System.Collections;

public class PlaceholderEnemyTowerBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		IEnumerator wait;
		for (int i=0; i<3; i++) {
			CreateUnit ();
			wait = WaitSecond ();
			
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateUnit(){
		GameObject newFighter = (GameObject) Instantiate (Resources.Load ("Placeholder/PlaceholderEnemyFighter"));
		newFighter.transform.position = new Vector2(53, -2);
	}
	IEnumerator WaitSecond(){
		yield return new WaitForSeconds (2);
	}
}
