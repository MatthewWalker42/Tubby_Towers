using UnityEngine;
using System.Collections;

public class PlayerFighterBehavior : MonoBehaviour {
	public float speed = 10.1f;
	public float health = 30.0f;
	public float damage = 10.0f;
	public float AtkSpeed = 0.5f;

	GameObject enemy;

	// Use this for initialization
	void Start () {
		speed = 10.1f;
		health = 30.0f;
		damage = 10.0f;
		AtkSpeed = 0.5f;
	
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



		//Destroy (crash.gameObject);
		if ( crash.gameObject.transform.tag =="Enemy")
		{
			this.speed = 0f;

			enemy = crash.gameObject;
			StartCoroutine(Attack (enemy));



		}

		if ( crash.gameObject.transform.tag =="Player")
		{
			this.speed = 0f;
			
		}

		if (crash.gameObject.name == "PlaceholderEnemyTower") 
		{
			this.speed = 0.0f;
		}

		}


	IEnumerator Attack(GameObject target){
		
		
		if(target.transform.tag == "Enemy")
		{
			while(target.transform.GetComponent<PlaceholderEnemyBehavior> ().health >= 0)
			{
				target.transform.GetComponent<PlaceholderEnemyBehavior> ().health -= this.damage;
			
			
				Debug.Log (target.transform.GetComponent<PlaceholderEnemyBehavior> ().health);
			
				if(target.transform.GetComponent<PlaceholderEnemyBehavior> ().health <= 0)
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
