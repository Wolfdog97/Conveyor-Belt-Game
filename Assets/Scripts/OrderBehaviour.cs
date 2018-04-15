using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderBehaviour : MonoBehaviour {

	public float velocity;
	bool stop = false;

	// Use this for initialization
	void Start () {
		Debug.Log ("stop ="+stop);
	}
	
	// Update is called once per frame
	void Update () {
		if (!stop)
			transform.position -= new Vector3 (1, 0, 0) * velocity * Time.deltaTime;
	
	}

	void OnTriggerEnter(Collider collider) 
	{
		if (collider.tag == "EndOfScreen" || collider.tag == "Order") {
			stop = true;
		}
	}
}
