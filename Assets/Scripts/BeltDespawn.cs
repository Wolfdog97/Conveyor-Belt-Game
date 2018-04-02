using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltDespawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
        if(other.gameObject.tag == "Belt"){
            Destroy(other.gameObject);
        }
	}
}
