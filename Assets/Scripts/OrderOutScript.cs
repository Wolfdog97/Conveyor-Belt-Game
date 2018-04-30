using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderOutScript : MonoBehaviour {

    PlateScript _plateScript;
    public AudioManager aM;

    //public List<Food> sushiList = new List<Food>();
    public OrderGeneration orderGenerator;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Plate")
        {
            Debug.Log("This appears to be a Plate!");
            _plateScript = other.GetComponent<PlateScript>();

           // Debug.Log("!!!!!!: " + _plateScript.platedSushi.Count);

            // Iterate through hashset and add each element to the list
            List<Food.FoodType> plateFoodTypes = ConvertHashSetToList(_plateScript.platedSushi);

            // run CompareList()
            List<Food.FoodType> matchingOrder = orderGenerator.GetOrder(plateFoodTypes);

            // If the plate's list doesn't match one of the Orders
            if (matchingOrder == null)
            {
                Debug.Log("doesn't match an order");
                //aM.Play("");
                Destroy(other);
            }
            // If the plate's list matches one of the order remove the order and get rid of plate
            else
            {
                orderGenerator.RemoveOrder(matchingOrder);
                //aM.Play("");
                Destroy(other);
            }
        }
    }

    private List<Food.FoodType> ConvertHashSetToList(HashSet<Food> hashSet)
    {
        List<Food.FoodType> foodTypeList = new List<Food.FoodType>();

        foreach(Food food in hashSet)
        {
            foodTypeList.Add(food.foodType);
        }
        return foodTypeList;
    }

    public static bool CompareList (List<Food.FoodType> a, List<Food.FoodType> b)
    {
        // Iterate through list a and list b
        // Check if they contain the same elements
        // return true if they match 
        if (a == null || b == null) return false;

        foreach(Food.FoodType type in a)
        {
            if (!b.Contains(type)) return false;
        }
        foreach (Food.FoodType type in b)
        {
            if (!a.Contains(type)) return false;
        }
        return true;
    }
}
