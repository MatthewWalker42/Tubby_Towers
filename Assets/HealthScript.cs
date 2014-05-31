using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {


	int health;
	// Use this for initialization
	void Start () {

		health = 15;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (this.health <= 0) {
			Death();		
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

	public void Damage(int d){
			
		this.health = this.health - d;
		}
}
