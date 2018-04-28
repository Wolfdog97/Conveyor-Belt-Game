using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateScript : MonoBehaviour {

    public HashSet<Food> platedSushi = new HashSet<Food>();
    
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

        Debug.Log("Current hashset Count: " + platedSushi.Count);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            //Debug.Log("food");
            Food otherFood = other.GetComponent<Food>();
            if (!platedSushi.Contains(otherFood))
            {
                platedSushi.Add(otherFood);
                Debug.Log("Adding " + other.gameObject.name + " to the hashset");

                other.transform.SetParent(this.transform);
				other.GetComponent<Rigidbody> ().isKinematic = true;


                // Debug.Log("Current hashset Count: " + platedSushi.Count);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            //Debug.Log("this is food");
            Food otherFood = other.GetComponent<Food>();

            if (platedSushi.Contains(otherFood))
            {
                Debug.Log("Taking things out of the hashset");

                platedSushi.Remove(otherFood);

                other.transform.SetParent(null);
				other.GetComponent<Rigidbody> ().isKinematic = false;

                //Debug.Log("Current hashset Count: " + platedSushi.Count);

            }
        }

    }
}

/* Right now it is adding the wrong object to the hashset. example: Test_Food(1) instead of Test_Food. 
 * 
 *   
 *   
 */