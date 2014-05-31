using UnityEngine;
using System.Collections;

public class PlaceholderPlayerTower : MonoBehaviour {

	protected Camera cameraloc;

	// Use this for initialization
	void Start () {

		cameraloc = (Camera) GameObject.Find("Main Camera").GetComponent<Camera> ();
	
		for (int i=0; i<1; i++) {
			//StartCoroutine(WaitSecond());


		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreateUnit(){
		GameObject newFighter = (GameObject) Instantiate (Resources.Load ("Placeholder/PlaceholderPlayerFighter"));
		newFighter.transform.position = new Vector2(-33, -2);
		}

	public void CreateRoller(){
		GameObject newFighter = (GameObject) Instantiate (Resources.Load ("Placeholder/PlaceholderRoller"));
		newFighter.transform.position = new Vector2(-33, 8);

	}

	public void CreateRanged(){
		GameObject newFighter = (GameObject) Instantiate (Resources.Load ("Placeholder/RangedFighter"));
				
		//Vector2 mousPos = cameraloc.ScreenToWorldPoint(Input.mousePosition);
		newFighter.transform.position = new Vector2(-32, -2);

	}

	IEnumerator WaitSecond(){

		for (int i = 0; i < 3; i++) {
						CreateUnit ();
						yield return new WaitForSeconds (3.0f);
				}
		//CreateUnit ();
		}

	IEnumerator WaitAround(){
		yield return new WaitForSeconds(1.0f);
	}

}
