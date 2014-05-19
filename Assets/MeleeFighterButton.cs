using UnityEngine;
using System.Collections;

public class MeleeFighterButton : MonoBehaviour {
	//public PlaceholderPlayerTower makeUnit;

	void OnClick(){
		GameObject go = GameObject.Find ("PlaceholderPlayerTower");
		PlaceholderPlayerTower makeUnit = (PlaceholderPlayerTower) go.GetComponent (typeof(PlaceholderPlayerTower));
		//Debug.Log ("I was clicked");
		makeUnit.CreateUnit ();
}
}