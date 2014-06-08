using UnityEngine;
using System.Collections;

public class PlayerRanged : MonoBehaviour {
	public float health = 30.0f;
	public float AtkSpeed = 0.5f;
	protected bool attackCool = false;
	protected Vector3 screenSpace;
	protected Vector3 offSet;
	protected Camera cameraLoc;
	public int BurgerLimit = 25;
	protected int BurgerCount = 0;

	GameObject enemy;

	//Ray ray;
	//RaycastHit hit;

	// Use this for initialization
	void Start () {
		health = 30.0f;
		AtkSpeed = 0.5f;
		cameraLoc = (Camera) GameObject.Find("Main Camera").GetComponent<Camera> ();
	
	}
	
	// Update is called once per frame
	void Update () {


		if(attackCool == false){
				StartCoroutine(Attack());	
		}

		if(BurgerCount >= BurgerLimit){
			this.transform.GetComponent<HealthScript> ().Damage (50);
		}
	
	}

	void OnMouseDown(){
		screenSpace = Camera.main.WorldToScreenPoint (transform.position); 
    	offSet = transform.position - Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z)); 
	}

	void OnMouseDrag(){
		Vector3 curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z); 
    Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offSet;
    if(curPosition.x > 20){
    	curPosition.x = 20;
    }
    if(curPosition.y < 4){
    	curPosition.y = 4;
    }
    else if(curPosition.x < -47){
    	curPosition.x = -40;
    }
    transform.position = curPosition; 
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
		BurgerCount += 1;
		
	}


	}
