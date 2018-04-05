using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("food");
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnTriggerEnter(Collider other)
    {
        HashSet<GameObject> platedSushi = new HashSet<GameObject>();
        Food platableFood = gameObject.GetComponent<Food>();

        if (platableFood != null)
        {
            Debug.Log("food");
        }
    }
}
