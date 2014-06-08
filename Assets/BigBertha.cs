﻿using UnityEngine;
using System.Collections;

public class BigBertha : MonoBehaviour {
	public float speed = 10.1f;
	public float health = 30.0f;
	public int damage = 10;
	public float AtkSpeed = 0.5f;
	
	GameObject enemy;
	
	// Use this for initialization
	void Start () {
		speed = 8.0f;
		health = 30.0f;
		damage = 10;
		AtkSpeed = 1f;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Move ();
		
		//Debug.Log (health);
		
	}
	
	void Move(){
		
		transform.Translate (Vector2.right * speed * Time.deltaTime);
	}
	
	//Basic collision detection checking for two differently named objects
	void OnCollisionEnter2D(Collision2D crash){


		if (crash.gameObject.name == "PlaceholderEnemyTower") 
		{
			this.speed = 0.0f;
		}

		if (crash.gameObject.transform.GetComponent<HealthScript> () != null) {
			
			this.speed = 0f;
			StartCoroutine (Attack (crash.gameObject));
			
		}
		
		
		

		
	}
	
	
	IEnumerator Attack(GameObject target){
		
		
		
		while (target != null) {
			target.transform.GetComponent<HealthScript> ().Damage (this.damage);
			
			
			Debug.Log (target.transform.GetComponent<HealthScript> ().getHealth ());
			
			yield return new WaitForSeconds (this.AtkSpeed);
			
			
			
		}
		this.speed = 8.0f;
		
		
	}
	
	public void keepMoving(){
		
		this.speed = 8.0f;
		
	}
	
	IEnumerator waitMove(){
		
		yield return new WaitForSeconds (2.0f);
		this.keepMoving ();
		
	}
	
}
