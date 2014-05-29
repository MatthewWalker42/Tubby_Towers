using UnityEngine;
using System.Collections;

public class CalorieLabel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		UILabel lbl = GetComponent<UILabel>();
		GameObject cal = GameObject.Find("CalorieTimer");
		lbl.text = "Calories: " + cal.GetComponent<Calories> ().numCalories.ToString();
	
	}
}
