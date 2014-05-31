using UnityEngine;
using System.Collections;

public class PlayerRanged : MonoBehaviour {
	public float health = 30.0f;
	public float AtkSpeed = 0.5f;
	protected bool attackCool = false;

	protected Camera cameraLoc;

	GameObject enemy;

	Ray ray;
	RaycastHit hit;

	// Use this for initialization
	void Start () {
		health = 30.0f;
		AtkSpeed = 0.5f;
		cameraLoc = (Camera) GameObject.Find("Main Camera").GetComponent<Camera> ();
	
	}
	
	// Update is called once per frame
	void Update () {

	ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       if(Physics.Raycast(ray, out hit))
       {
         Debug.Log(hit.collider.name);
       }


		if(attackCool == false){
				StartCoroutine(Attack());	
		}

		//OnMouseOver();

		//Debug.Log (health);
	
	}

	void OnMouseOver(){
		Debug.Log("Mouse over!");
		if(Input.GetMouseButton(0)){
			Debug.Log ("Mouse click!");
			while(!Input.GetMouseButtonUp(0)){
				//this.transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
			}

		}
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
