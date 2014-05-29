using UnityEngine;
using System.Collections;

public class MeleeFighterButton : MonoBehaviour {
	public int cost = 5;


	void OnClick(){
		GameObject calorieSubtract = GameObject.Find("CalorieTimer");

		if (calorieSubtract.GetComponent<Calories>().numCalories >= cost)
		{

			GameObject go = GameObject.Find ("PlaceholderPlayerTower");
			PlaceholderPlayerTower makeUnit = (PlaceholderPlayerTower) go.GetComponent (typeof(PlaceholderPlayerTower));
			makeUnit.CreateUnit ();
			//this.isEnabled(false);
			calorieSubtract.GetComponent<Calories> ().numCalories -= this.cost;
		}
	}
}