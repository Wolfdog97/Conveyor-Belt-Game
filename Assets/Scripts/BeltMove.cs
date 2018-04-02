using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltMove : MonoBehaviour {

    public float speed = 0.5f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //this.transform.position += transform.right * Time.deltaTime * speed;

        this.GetComponent<Rigidbody>().velocity = transform.right * speed;
	}
}
