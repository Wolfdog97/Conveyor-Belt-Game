using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using Valve.VR.InteractionSystem;

public class PlateCollision : MonoBehaviour {

	public Animator plateAnimator;
	public bool plateCollided;
	private Hand hand;

	// Use this for initialization
	void Start () {
		hand = GetComponent<Hand>();   
		plateAnimator = GetComponent<Animator> ();

	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.A)){
			plateAnimator.SetTrigger ("plateCollision");
		}

	}

	void OnCollisionEnter (Collision collision)

	{
		print ("Colliding");
		if (hand.controller.GetHairTriggerDown())
		{
			print ("triggering");
			plateAnimator.SetTrigger ("plateCollision");
		}
	}
}
