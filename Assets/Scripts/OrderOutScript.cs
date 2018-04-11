using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderOutScript : MonoBehaviour {

    PlateScript _plateScript;

    public List<Food> sushiList = new List<Food>();

    //temporary
    private List<Food.FoodType> tempRecipe = new List<Food.FoodType>() { Food.FoodType.Salmon, Food.FoodType.Shrimp, Food.FoodType.Tuna, Food.FoodType.YellowTail };

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Plate")
        {
            Debug.Log("This appears to be a Plate!");
            _plateScript = other.GetComponent<PlateScript>();

            Debug.Log("!!!!!!: " + _plateScript.platedSushi.Count);

            // Iterate through hashset and add each element to the list
            List<Food.FoodType> plateFoodTypes = ConvertHashSetToList(_plateScript.platedSushi);

            // run CompareList()
            bool matchingPlate = CompareList(plateFoodTypes, tempRecipe);

            if(matchingPlate)
            {
                Debug.Log("correct plate!");
            }
            else
            {
                Debug.Log("mistake!");
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

    private bool CompareList (List<Food.FoodType> a, List<Food.FoodType> b)
    {
        // Iterate through list a and list b
        // Check if they contain the same elements
        // return true if they match 
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
