using UnityEngine;
using System.Collections;

public class MoveMainCamera : MonoBehaviour {

	public float speed = 1.0f;

	public float maxX = 100f;
	public float maxY = 30f;
	public float minX = -50f;
	public float minY = 6f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

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
