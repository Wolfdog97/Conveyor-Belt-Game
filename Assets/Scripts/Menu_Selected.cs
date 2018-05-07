using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Selected : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
        if(other.tag == "Sushi_Egg")
        {
            SceneManager.LoadScene("Scene_Final_Main");
            Debug.Log("SushiChecker works");
        }
        else if(other.tag == "Sushi_Salmon")
        {
            Application.Quit();
            Debug.Log("Other Checking");
        }
	}
}
