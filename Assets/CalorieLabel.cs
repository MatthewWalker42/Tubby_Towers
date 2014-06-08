using UnityEngine;
using System.Collections;

public class CalorieLabel : MonoBehaviour {
	protected UILabel lbl;
	protected GameObject cal;

	// Use this for initialization
	void Start () {
		lbl = GetComponent<UILabel>();
		cal = GameObject.Find("CalorieTimer");
	
	}
	
	// Update is called once per frame
	void Update () {

		lbl.text = "Calories: " + cal.GetComponent<Calories> ().numCalories.ToString();
	
	}
}
