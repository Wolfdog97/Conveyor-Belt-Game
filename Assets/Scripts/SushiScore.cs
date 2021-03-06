﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SushiScore : MonoBehaviour {
    
    public float score = 0f;

    public Text myText;

    public GameObject myTextFile;

    public GameObject employeeCanvas;

    public GameObject throw_hope;

    public GameObject fired;

    public bool check = true;

	// Use this for initialization
	void Start () {

        myTextFile.SetActive(true);

        employeeCanvas.SetActive(true);

        throw_hope.SetActive(false);

        fired.SetActive(false);
	}


	
	// Update is called once per frame
	void Update () {
        myText.text = "$" + score.ToString();

        if (score < -200f)
        {
            Debug.Log("you loose");
            //end game canvas, says you loose, Destroy(hope);

            employeeCanvas.SetActive(false);

            myTextFile.SetActive(false);


            fired.SetActive(true);

            throw_hope.SetActive(true);

            check = false;
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (check)
        {
            if (other.tag == "Food")
            {
                score -= 10f;
                Destroy(other);

                Debug.Log("After: ");
                Debug.Log(score);
            }
        }
    }

}
