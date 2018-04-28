using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class PlateCollision : MonoBehaviour {

	public Animator plateAnimator;
	public bool plateCollided;

	// Use this for initialization
	void Start () {
		plateAnimator = this.GetComponent<Animator> ();
		plateAnimator.SetBool ("plateCollided", true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

//	void OnCollisionEnter (Collision collision)
//	{
//		if (collision.gameObject.)
//	}
}
