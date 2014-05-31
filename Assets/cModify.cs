using UnityEngine;
using System.Collections;

public class cModify : MonoBehaviour {
	protected UILabel lbl;
	protected GameObject cal;
	int modifier;
	bool cool = false;

	// Use this for initialization
	void Start () {
		lbl = GetComponent<UILabel>();
		modifier = 0;
		cal = GameObject.Find("CalorieTimer");
	}
	
	// Update is called once per frame
	void Update () {

		if (!cool){
			modifier = cal.GetComponent<Calories> ().bonus;
			StartCoroutine(DisplayMod());
		} 

	
	}

	IEnumerator DisplayMod(){
		if(modifier == 0){
			lbl.text = " ";
		}
		else if(modifier > 0){
			lbl.text = " +" + modifier;
		}
		else if(modifier < 0){
			lbl.text = " " + modifier;
		}

		cool = true;
		yield return new WaitForSeconds(1.0f);
		cool = false;
		modifier = 0;
	}
}
