using UnityEngine;
using System.Collections;

public class MouseObserverBehavior : MonoBehaviour {

	Ray ray;
	RaycastHit hit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       if(Physics.Raycast(ray, out hit))
       {
         Debug.Log("I hit something!");
       }
       Debug.DrawRay(transform.position, forward, Color.green);
	
	}
}
