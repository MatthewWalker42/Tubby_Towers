using UnityEngine;
using System.Collections;

public class PlayerFighterBehavior : MonoBehaviour {
	public float speed = 10.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	
	}

	void Move(){

		transform.Translate (Vector2.right * speed * Time.deltaTime);
		}
}
