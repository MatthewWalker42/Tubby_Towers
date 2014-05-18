using UnityEngine;
using System.Collections;

public class PlaceholderEnemyBehavior : MonoBehaviour {
	public float speed = 10.1f;
	public float dmg = 15.0f;
	public float health = 30.0f;
	public float AtkSpeed = 1.0f;

	GameObject player;



	// Use this for initialization
	void Start () {

		speed = 10.1f;
		dmg = 15.0f;
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

		if ( crash.gameObject.transform.tag =="Player")
		{
			this.speed = 0f;
			player = crash.gameObject;
			StartCoroutine ( Attack (player));

		
		}

		if (crash.gameObject.transform.tag == "Enemy") {

			this.speed = 0;

		}

		if (crash.gameObject.name == "PlaceholderPlayerTower") 
		{
			this.speed = 0.0f;
		}
	
	}

	IEnumerator Attack(GameObject target){


		if(target.transform.tag == "Player"){
			while(target.transform.GetComponent<PlayerFighterBehavior> ().health >= 0)
			{
				target.transform.GetComponent<PlayerFighterBehavior> ().health -= this.dmg;


				Debug.Log (target.transform.GetComponent<PlayerFighterBehavior> ().health);

				if(target.transform.GetComponent<PlayerFighterBehavior> ().health <= 0)
				{
					Destroy (target);
				}
				else
				{
					yield return new WaitForSeconds(this.AtkSpeed);
				}


			}
		}
		this.speed = 10.1f;
	}





}
