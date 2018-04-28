using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderDisplayController : MonoBehaviour {

    [SerializeField]
    OrderGeneration OrderGeneration;
    public List<Food.FoodType> orderDisplayed;
    private SpriteRenderer[] sprites;

    // Use this for initialization
    void Start () {
        //AddOrderDisplay(new List<Food.FoodType>() { Food.FoodType.Salmon, Food.FoodType.YellowTail, Food.FoodType.Shrimp });
        sprites = GetComponentsInChildren<SpriteRenderer>();
        orderDisplayed = null;
    }
	
	
	void Update () {
	}

   public void AddOrderDisplay(List<Food.FoodType> order)
    {
        orderDisplayed = order;

        for (int i = 0; i < order.Count; i++)
        {
            sprites[i].sprite = OrderGeneration.foodSprites[(int)order[i]];
        }
    }


    public void ClearDisplay()
    {
        foreach (SpriteRenderer sr in sprites)
        {
            sr.sprite = null;
        }

        orderDisplayed = null;
    }
}
