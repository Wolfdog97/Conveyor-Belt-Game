using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderOnScreen : MonoBehaviour {

	public float timer;
	public GameObject[] orders;
	int index;
	float timerStart;

	// Use this for initialization
	void Start () {
		timerStart = timer;
	}

	// Update is called once per frame
	void Update () {
		
		timer -= Time.deltaTime;

		if (timer <= 0)
		{
			index = Random.Range(0,orders.Length);
			Instantiate (orders[index]);
			timer = timerStart;
		}


	}
}