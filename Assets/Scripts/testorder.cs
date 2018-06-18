using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testorder : MonoBehaviour {

    public List<Food.FoodType> order;
    public OrderGeneration OrderGen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            List<Food.FoodType> matchingOrder = OrderGen.GetOrder(order);
            if (matchingOrder == null)
            {
                Debug.Log("no matching order");
            }
            else
            {
                OrderGen.RemoveOrder(matchingOrder);
            }
        }
	}
}
