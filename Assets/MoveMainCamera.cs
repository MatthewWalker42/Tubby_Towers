using UnityEngine;
using System.Collections;

public class MoveMainCamera : MonoBehaviour {

	public float speed = 1.0f;

	public float maxX = 100f;
	public float maxY = 30f;
	public float minX = -50f;
	public float minY = 6f;
	protected bool startCool = false;
	protected bool panStart = true;
	protected bool resetCam = false;

	// Use this for initialization
	void Start () {
		//StartCoroutine(waitASecond());
		
	
	}
	
	// Update is called once per frame
	void Update () {

		if(panStart){
			if(transform.position.x < maxX){
				transform.position += new Vector3(20f * Time.deltaTime, 0, 0);

			}
			else if(transform.position.x >= maxX){
				if (startCool){
					panStart = false;
					resetCam = true;

				}
				else {
					StartCoroutine(waitASecond());
				}


			}
		}

		if(resetCam){
			transform.position = new Vector3(17, 19, -80);
			resetCam = false;
		}

		if(!panStart && !resetCam){
		if(transform.position.x <= minX){
			transform.position = new Vector3(minX, transform.position.y, transform.position.z);
		}
		if(transform.position.y <= minY){
			transform.position = new Vector3(transform.position.x, minY, transform.position.z);
		}
		if(transform.position.x >= maxX){
			transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
		}
		if(transform.position.y >= maxY){
			transform.position =  new Vector3(transform.position.x, maxY, transform.position.z);
		}

		if(Input.GetKey(KeyCode.D)){
			transform.position += new Vector3(speed * Time.deltaTime, 0,0);

		}
		if(Input.GetKey(KeyCode.A)){
			transform.position -= new Vector3(speed * Time.deltaTime, 0,0);
		}
		if(Input.GetKey(KeyCode.W)){
			transform.position += new Vector3(0, speed * Time.deltaTime, 0);

		}
		if(Input.GetKey(KeyCode.S)){
			transform.position -= new Vector3(0, speed *Time.deltaTime, 0);
		}
	}
	
	}

	IEnumerator PanCamera(){
		bool cooloff = false;
		while(transform.position.x < maxX){
			transform.position += new Vector3(1f * Time.deltaTime, 0, 0);
		}
		cooloff = true;
		yield return new WaitForSeconds(2);
		cooloff = false;
		if(cooloff == false){
		   transform.position = new Vector3(17, 19, -80);
		}

	}

	IEnumerator waitASecond(){
		yield return new WaitForSeconds(1);
		startCool = true;
	}
}
