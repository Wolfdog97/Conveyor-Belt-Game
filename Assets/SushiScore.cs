using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiScore : MonoBehaviour {

    public float score = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	private void OnTriggerEnter(Collider other)
	{
        if(other.tag == "Sushi"){
            score -= 10f;
            Destroy(other);
        }
        if(other.tag == "Plate"){
            //plate checker if statement
            score += 100f;
            Destroy(other);
        }
	}
}
