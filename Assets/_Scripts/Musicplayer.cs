using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicplayer : MonoBehaviour {
		static Musicplayer instance=null;

	void Awake ()
	{
		Debug.Log ("Music Player is Awake " + GetInstanceID ());
		if (instance != null) {
			DestroyObject (gameObject);
			print ("Duplicate Music Player has been  Self Destructed");
		} else {
			//instance = this; 
			//GameObject.DontDestroyOnLoad (gameObject);
		}

	}
	void Start ()
	{
		Debug.Log("Music Player is started" + GetInstanceID());

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
