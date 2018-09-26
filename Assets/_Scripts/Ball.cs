using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	private Vector3 padtoball;
	private bool hasstarted=false;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
	paddle=GameObject.FindObjectOfType<Paddle>();
	rb=GameObject.FindObjectOfType<Rigidbody2D>();
		padtoball=this.transform.position - paddle.transform.position;

	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!hasstarted) {

			this.transform.position = paddle.transform.position + padtoball;
		
			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse is clicked");
				hasstarted=true;
				rb=this.GetComponent<Rigidbody2D>();
				rb.velocity=new Vector2(2f,10f);

			}
		}


	}
	void OnCollisionEnter2D (Collision2D coll)
	{
	 Vector2 tweak=new Vector2(Random.Range(0f,0.3f),Random.Range(0f,0.5f));
	 if(hasstarted)
	 {
		rb.velocity=rb.velocity+tweak;
		}
	}

}
