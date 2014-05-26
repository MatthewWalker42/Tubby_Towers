using UnityEngine;
using System.Collections;

public class PlayerRanged : MonoBehaviour {
	public float health = 30.0f;
	public float AtkSpeed = 0.5f;
	protected bool attackCool = false;

	GameObject enemy;

	// Use this for initialization
	void Start () {
		health = 30.0f;
		AtkSpeed = 0.5f;
	
	}
	
	// Update is called once per frame
	void Update () {

		if(attackCool == false){
				StartCoroutine(Attack());	
		}


		//Debug.Log (health);
	
	}


	//Basic collision detection checking for two differently named objects
	void OnCollisionEnter2D(Collision2D crash){

		//Destroy (crash.gameObject);


		if ( crash.gameObject.transform.tag =="Player")
		{
			
		}

		}


	IEnumerator Attack(){
		GameObject newProjectile = (GameObject) Instantiate (Resources.Load ("Placeholder/Projectile"));
		newProjectile.transform.position = new Vector2(this.transform.position.x + 2, this.transform.position.y + 1);
		attackCool = true;
		yield return new WaitForSeconds (2.0f);
		attackCool = false;
		
	}


	}
