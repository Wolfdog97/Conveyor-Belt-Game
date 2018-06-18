using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltScript : MonoBehaviour {

    public GameObject belt;

	private void OnTriggerExit(Collider other)
	{
        if(other.gameObject.tag == "Belt"){
            //Instantiate(//new_belt);
            Instantiate(belt, this.transform.position, Quaternion.identity);

        }
	}
}
