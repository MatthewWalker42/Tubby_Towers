using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		StartCoroutine ("WaitSecond");


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateUnit(){
		GameObject newFighter = (GameObject) Instantiate (Resources.Load ("Placeholder/PlaceholderPlayerFighter"));
		newFighter.transform.position = new Vector2(-33, -2);
		}
	IEnumerator WaitSecond(){
		yield return new WaitForSeconds (2);

		//IEnumerator wait;
		for (int i=0; i<3; i++) {
			CreateUnit ();
			//wait = WaitSecond ();
			
		}

		StartCoroutine ("WaitSecond");
	}
}
