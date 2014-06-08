using UnityEngine;
using System.Collections;

public class BackgroundMusicScript : MonoBehaviour {
	public AudioClip otherClip;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(!audio.isPlaying){
			audio.clip = otherClip;
			audio.Play();
		}

	
	}
}
