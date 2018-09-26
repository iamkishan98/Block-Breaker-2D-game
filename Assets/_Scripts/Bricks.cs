using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {
	// Use this for initialization
	public int maxhits;
	public AudioClip music;
	public AudioSource sound;
	private int hitcount;
	private LevelManager levelmanage;
	public static int breakcount=0; 
	void Start () {
			sound=GetComponent<AudioSource>();
			breakcount++;
			Debug.Log(breakcount);
			hitcount=0;
			levelmanage=GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D (Collision2D col)
	{
		AudioSource.PlayClipAtPoint(music,transform.position);
		hitcount++;
		if (hitcount >= maxhits) {
			breakcount--;
			Debug.Log(breakcount);
		
			Destroy (gameObject);
			if(breakcount<=0)
			{
				
				levelmanage.BricksDestroyed();

				sound.Play();
				
			}
		}
	}

}
