using UnityEngine;
using System.Collections;

public class RollerFighter : MonoBehaviour {

	public float speed;
	public float damage;

	// Use this for initialization
	void Start () {
		speed = 5f;
		damage = 30;
	}
	
	// Update is called once per frame
	void Update () {

		rigidbody2D.AddForce (Vector2.right * speed);
	
	}

	void OnCollisionEnter2D(Collision2D crash){

		if (crash.gameObject.transform.tag == "Enemy") {

			crash.gameObject.transform.GetComponent<PlaceholderEnemyBehavior> ().health -= this.damage;
			if(crash.gameObject.transform.GetComponent<PlaceholderEnemyBehavior> ().health <= 0){

				Destroy (crash.gameObject);
			}

			Debug.Log ("Enemy Crash");
		}

		if (crash.gameObject.transform.tag == "Player") {

			crash.gameObject.transform.GetComponent<PlayerFighterBehavior> ().health -= this.damage;

			if(crash.gameObject.transform.GetComponent<PlayerFighterBehavior> ().health  <= 0){
				Destroy (crash.gameObject);
			}
			Debug.Log ("Player Crash");
		}

		if (crash.gameObject.transform.tag == "EnemyTower") {

			Destroy(this.gameObject);
			Debug.Log ("Tower Crash");
		}

	}
}
