using UnityEngine;
using System.Collections;

public class BigBerthaButtonScript : MonoBehaviour {

	// Use this for initialization
	public int cost = 20;
	protected UIButton buttonScript;
	protected GameObject calorieSubtract;
	public float buttonCool = 8.0f;
	protected bool onCooldown = false;
	protected GameObject go;
	protected PlaceholderPlayerTower makeUnit;

	void Start () {
		buttonScript = GetComponent<UIButton>();
		calorieSubtract = GameObject.Find("CalorieTimer");
		go = GameObject.Find ("PlaceholderPlayerTower");
		makeUnit = (PlaceholderPlayerTower) go.GetComponent (typeof(PlaceholderPlayerTower));
	}

	void OnClick(){

		if (calorieSubtract.GetComponent<Calories>().numCalories >= cost && !onCooldown)
		{
			makeUnit.CreateBirtha ();
			calorieSubtract.GetComponent<Calories> ().numCalories -= this.cost;
			StartCoroutine (CoolDown());
		}

	}

	IEnumerator CoolDown (){
		buttonScript.isEnabled = false;
		onCooldown = true;
		yield return new WaitForSeconds(buttonCool);
		onCooldown = false;
		buttonScript.isEnabled = true;
	}
}
