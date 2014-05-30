using UnityEngine;
using System.Collections;

public class Calories : MonoBehaviour {

	protected float _cTimer = 0f;
	public int startCalories = 15;
	public int numCalories = 0;
	protected int prevcTimer = 0;

	// Use this for initialization
	void Start () {
		numCalories = startCalories;
		prevcTimer = (int) _cTimer;
	
	}
	
	// Update is called once per frame
	void Update () {
		_cTimer += Time.deltaTime;
		//Debug.Log("Calories: " + numCalories);
		if ((int) _cTimer > prevcTimer){
			numCalories += 1;
			prevcTimer = (int) _cTimer;
		}
	
	}


}
