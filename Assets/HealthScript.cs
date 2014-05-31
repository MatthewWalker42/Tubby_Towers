using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {


	int health;
	public int bonusPoints = 2;
	GameObject cal;

	// Use this for initialization
	void Start () {
		cal = GameObject.Find("CalorieTimer");
		health = 15;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (this.health <= 0) {
			Death();
			cal.GetComponent<Calories> ().numCalories += this.bonusPoints;	
			cal.GetComponent<Calories> ().bonus = this.bonusPoints;	
		}
	
	}

	public void Death(){

		Destroy (this.gameObject);

		}
	public int getHealth(){

		return this.health;

		}

	public void setHealth(int h){

		this.health = h;
		}

	public void setPoints(int p){
		this.bonusPoints = p;
	}

	public void Damage(int d){
			
		this.health = this.health - d;
		}
}
