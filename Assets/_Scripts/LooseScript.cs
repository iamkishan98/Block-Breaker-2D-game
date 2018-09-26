using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseScript : MonoBehaviour {

	// Use this for initialization
	private LevelManager levelmanage;
	void Start ()
	{
		levelmanage=GameObject.FindObjectOfType<LevelManager>();
	}
	void OnTriggerEnter2D (Collider2D collider)
	{
	print("Trigger");

	}
	void OnCollisionEnter2D (Collision2D collision)
	{
		print("Collision");
		levelmanage.LoadLevel("Lose");

	}
}
