using UnityEngine;
using System.Collections;

public class RollerButtonScript : MonoBehaviour {

	void OnClick(){
		GameObject go = GameObject.Find ("PlaceholderPlayerTower");
		PlaceholderPlayerTower makeUnit = (PlaceholderPlayerTower) go.GetComponent (typeof(PlaceholderPlayerTower));
		//Debug.Log ("I was clicked");
		makeUnit.CreateRoller ();
	}
}
