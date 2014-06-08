using UnityEngine;
using System.Collections;

public class PlaceholderEnemyBehavior : MonoBehaviour {
	public float speed = 10.1f;
	public int dmg = 15;
	public float health = 30.0f;
	public float AtkSpeed = 1.0f;

	GameObject player;



	// Use this for initialization
	void Start () {

		speed = 10.1f;
		dmg = 10;
		health = 30.0f;
		AtkSpeed = 1.0f;
	
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	
	}

	void Move(){
		
		transform.Translate (Vector2.right * -speed * Time.deltaTime);
	}


	void OnCollisionEnter2D(Collision2D crash){
			
		if (crash.gameObject.transform.GetComponent<HealthScript> () != null) {
					
			this.speed = 0f;
			StartCoroutine (Attack (crash.gameObject));
				
				}

		if (crash.gameObject.name == "PlaceholderPlayerTower") 
		{
			this.speed = 0.0f;
		}
	
	}

	IEnumerator Attack(GameObject target){



			while(target != null)
			
			{
				target.transform.GetComponent<HealthScript> ().Damage (dmg);


				Debug.Log (target.transform.GetComponent<HealthScript> ().getHealth());

				yield return new WaitForSeconds(this.AtkSpeed);



			}

		this.speed = 10.1f;
	}





}
