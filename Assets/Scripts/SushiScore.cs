using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SushiScore : MonoBehaviour {
    
    public float score = 0f;
    public Text myText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        myText.text = "$" + score.ToString();
	}

	private void OnTriggerEnter(Collider other)
	{
        if(other.tag == "Food"){
            score -= 10f;
            Destroy(other);
            Debug.Log(score);
        }
        if(other.tag == "Plate"){
            //plate checker if statement


            score += 100f;
            Destroy(other);
            Debug.Log(score);
        }
	}


}
