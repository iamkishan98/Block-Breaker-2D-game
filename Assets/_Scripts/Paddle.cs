using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
	
	public bool autoplay=false;
	private Ball ball;
	// Use this for initialization
	void Start ()
	{
		ball=GameObject.FindObjectOfType<Ball>();
	}
	void Autoplay ()
	{
		Vector3 paddlepos=new Vector3(0.5f,this.transform.position.y,-0.5f);
		float ballpos=ball.transform.position.x;
		paddlepos.x=Mathf.Clamp(ballpos,0.5f,15.5f);
		this.transform.position=paddlepos;
	}
	// Update is called once per frame
	void Update ()
	{
		if (!autoplay) {
			Movewithmouse ();
		} else {
			Autoplay();
		}
	}
	void Movewithmouse ()
	{
		Vector3 paddlepos=new Vector3(0.5f,this.transform.position.y,-0.5f);
	
		float mousepos = Input.mousePosition.x/Screen.width * 16;
		paddlepos.x=Mathf.Clamp(mousepos,0.5f,15.5f);

		this.transform.position=paddlepos;
	}
}
