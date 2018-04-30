using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderGeneration : MonoBehaviour {

    ShuffleBag<Food.FoodType> randomBag = 
        new ShuffleBag<Food.FoodType>(new Food.FoodType[]{Food.FoodType.Salmon, Food.FoodType.Shrimp, Food.FoodType.Tuna, Food.FoodType.YellowTail});

    public List<List<Food.FoodType>> currentOrders;

    

    public Sprite[] foodSprites;

    public OrderDisplayController[] orderdisplayControllers;

    public int orderSize;
    private float orderTimer;
    public float timeBetweenOrders;
    public int maxOrders;
	public TextMesh[] orders;

    private void Start()
    {
        currentOrders = new List<List<Food.FoodType>>();
        AddNewOrder();
    }

    private void Update()
    {
        if (currentOrders.Count < maxOrders)
        {
            orderTimer += Time.deltaTime;
            if (orderTimer >= timeBetweenOrders)
            {
                orderTimer = 0;
                AddNewOrder();
            }
        }
        Debug.Log("current orders" + currentOrders.Count);
    }

    private void AddNewOrder()
    {
        List<Food.FoodType> newOrder = CreateOrder(orderSize);
        currentOrders.Add(newOrder);
        Debug.Log("adding new order:");
        foreach (Food.FoodType foodType in newOrder)
        {
            Debug.Log(foodType);
        }

        //for (int i = 0; i < newOrder.Count; ++i)
        //{
        //    orders[i].text = newOrder[i].ToString();
        //}

        foreach (OrderDisplayController display in orderdisplayControllers)
        {
            if(display.orderDisplayed == null)
            {
                display.AddOrderDisplay(newOrder);
                break;
            }
        }
    }

    public List<Food.FoodType> CreateOrder(int orderSize)
    {
        List<Food.FoodType> order = new List<Food.FoodType>();
        for (int i = 0; i < orderSize; i++)
        {
            order.Add(randomBag.Next());
        }
        return order;
    }

    public List<Food.FoodType> GetOrder(List<Food.FoodType> orderToCompare)
    {
        List<Food.FoodType> orderToReturn = null;
        foreach (List<Food.FoodType> order in currentOrders)
        {
            if (OrderOutScript.CompareList(orderToCompare, order))
            {
                orderToReturn = order;
                break;
            }
        }
        return orderToReturn;
    }

    public void RemoveOrder(List<Food.FoodType> order)
    {
        currentOrders.Remove(order);

        foreach (OrderDisplayController display in orderdisplayControllers)
        {
            if(OrderOutScript.CompareList(order, display.orderDisplayed))
            {
                display.ClearDisplay();
                break;
            }
        }
    }

} 


// Need this script to create a new public list of type FoodType for the OrderOutScript to check against
