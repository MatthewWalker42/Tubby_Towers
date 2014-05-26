using UnityEngine;
using System.Collections;

public class RangedButtonScript : MonoBehaviour {

	void OnClick(){
		GameObject go = GameObject.Find ("PlaceholderPlayerTower");
		PlaceholderPlayerTower makeUnit = (PlaceholderPlayerTower) go.GetComponent (typeof (PlaceholderPlayerTower));
		makeUnit.CreateRanged ();
	}
}
