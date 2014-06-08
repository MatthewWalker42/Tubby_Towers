using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {
	public float initialAngle = 30.0f;
	public float initialVelocity = 20.0f;
	public float g = 9.8f;
	public float dmg = 50.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Move();

		//rigidbody2D.AddForce (Vector2.right * speed);
	
	}

	void Move(){
		transform.Translate (Vector2.right * initialVelocity * Time.deltaTime * Mathf.Cos(initialAngle));
		transform.Translate (Vector2.up * initialVelocity * Time.deltaTime * Mathf.Sin(initialAngle) - (Vector2.up * 0.5f * g * Mathf.Pow(Time.deltaTime, 2.0f)));
	}

	void OnCollisionEnter2D (Collision2D crash){
		GameObject target = crash.gameObject;
		if(target.gameObject.transform.tag =="Enemy"){
			target.transform.GetComponent<PlaceholderEnemyBehavior> ().health -= this.dmg;

			if(target.transform.GetComponent<PlaceholderEnemyBehavior> ().health <= 0){
				Destroy (target);
			}

		}
		Destroy(this.gameObject);
	}

}
