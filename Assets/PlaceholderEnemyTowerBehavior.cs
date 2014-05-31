using UnityEngine;
using System.Collections;

public class PlaceholderEnemyTowerBehavior : MonoBehaviour {
	public float wait = 1.0f;
	public float firstIndividualSeconds = 3.0f;
	public float firstMobSeconds = 15.0f;
	public float secondIndividualSeconds = 2.0f;
	public float secondMobSeconds = 10.0f;
	public float finalIndividualSeconds = 2.0f;
	public float finalMobSeconds = 5.0f;
	public int firstNumberOfMob = 5;
	public int secondNumberOfMob = 5;
	public int finalNumberOfMob = 7;
	public float endFirstPhase = 30.0f;
	public float endSecondPhase = 120.0f;
	protected float actualTimer = 0f;
	protected bool timePassed = true;
	public float health;

	// Use this for initialization
	void Start () {
		this.transform.GetComponent<HealthScript> ().setHealth (500);

		//StartCoroutine (WaitSecond ());
		
	
	}
	
	// Update is called once per frame
	void Update () {
		actualTimer += Time.deltaTime;
		//Debug.Log ("timePassed: " + timePassed);
		if (actualTimer > 3.0f && timePassed) {
						StartCoroutine (Timer (actualTimer));
				}
	
	}

	IEnumerator CreateUnit(float waitTime){
		GameObject newFighter = (GameObject) Instantiate (Resources.Load ("Placeholder/PlaceholderEnemyFighter"));
		newFighter.transform.position = new Vector2(53, -2);
		newFighter.layer = 9;
		newFighter.transform.GetComponent<HealthScript> ().setHealth (30);
		//Debug.Log (newFighter.layer.ToString ());
		timePassed = false;
		yield return new WaitForSeconds(waitTime);
		timePassed = true;
	}

	void CreateUnitNoWait(){
		GameObject newFighter = (GameObject) Instantiate (Resources.Load ("Placeholder/PlaceholderEnemyFighter"));
		newFighter.layer = 9;
		newFighter.transform.GetComponent<HealthScript> ().setHealth (30);
		newFighter.transform.position = new Vector2(53, -2);
		}
	IEnumerator CreateMultipleUnits(int n){
				for (int i=0; i< n; i++) {
			CreateUnitNoWait ();
			timePassed = false;
			yield return new WaitForSeconds(0.8f);
			timePassed = true;
				}
		timePassed = false;
		yield return new WaitForSeconds(wait);
		timePassed = true;

		}

	IEnumerator WaitSecond(){
	
		for (int i=0; i<3; i++) {
			CreateUnit (wait);
			yield return new WaitForSeconds (3.0f);
			
		}

	}

	IEnumerator Timer (float actualTimer){

				if (actualTimer > endSecondPhase) {
						StartCoroutine(FinalPhase (actualTimer));
				} else if (actualTimer > endFirstPhase) {
						StartCoroutine(SecondPhase (actualTimer));

				} else {
						StartCoroutine(FirstPhase (actualTimer));
				}
		yield return new WaitForSeconds (wait);
		}
	IEnumerator FirstPhase(float timing){
		if ((int)timing % firstIndividualSeconds == 0) {
			StartCoroutine(CreateUnit (wait));
			yield return new WaitForSeconds (wait);
		}
	}

	IEnumerator SecondPhase(float timing){
		//Debug.Log ("Second Phase!");
		//Debug.Log ("2nd Indiv: " + (int)timing % secondIndividualSeconds);
		//Debug.Log ("2nd Mob: " + (int)timing % secondMobSeconds);
		if((int)timing % secondMobSeconds == 0){
			StartCoroutine(CreateMultipleUnits(secondNumberOfMob));
			yield return new WaitForSeconds (wait);
		}
		else if ((int) timing % secondIndividualSeconds == 0) {
			StartCoroutine(CreateUnit (wait));
			yield return new WaitForSeconds (wait);
		}

	}

	IEnumerator FinalPhase(float timing){
		if((int) timing % finalMobSeconds == 0){
			StartCoroutine(CreateMultipleUnits(finalNumberOfMob));
			yield return new WaitForSeconds (wait);
		}
		else if ((int) timing % finalIndividualSeconds == 0) {
			StartCoroutine(CreateUnit (wait));
			yield return new WaitForSeconds (wait);
		}
	}
}