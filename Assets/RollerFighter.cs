using UnityEngine;
using System.Collections;

public class RollerFighter : MonoBehaviour {

	public float speed;
	public int damage;

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



		if (crash.transform.GetComponent<HealthScript> () != null) {
			this.transform.GetComponent<HealthScript> ().Damage (5);
			crash.transform.GetComponent<HealthScript>().Damage (this.damage);

				}

	
		if (crash.gameObject.transform.tag == "EnemyTower") {

			Destroy(this.gameObject);
			Debug.Log ("Tower Crash");
		}

	}
}
