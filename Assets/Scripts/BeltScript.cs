using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltScript : MonoBehaviour {

    public GameObject belt;

    //struct{
    //    GameObject sushi;
    //}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerExit(Collider other)
	{
        if(other.gameObject.tag == "Belt"){
            //            Instantiate(//new_belt);
            Instantiate(belt, this.transform.position, Quaternion.identity);

        }
	}
}
