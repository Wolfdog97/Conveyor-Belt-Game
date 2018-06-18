using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using UnityEngine.UI;
using TMPro;


public class garbage_score_save : MonoBehaviour {

    public SushiScore sushiScore;

    public int highScore = 0;

    public TextMeshPro myText;

    //public List<float> myfloats = new List<float>{};

	// Use this for initialization
	void Start () {
        highScore = PlayerPrefs.GetInt("highScore", highScore);

        myText.text = "$" + highScore.ToString();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Food"){
            Destroy(other.gameObject);
            //sushiScore.score -= 5f;
        }
        if(other.tag == "hope"){
           

            sushiScore.check = true;

            if(sushiScore.score > highScore){
                highScore = (int)sushiScore.score;
                PlayerPrefs.SetInt("highScore", (int)sushiScore.score);
                PlayerPrefs.Save();
            }

            //sushiScore.fired.SetActive(false);

            //sushiScore.throw_hope.SetActive(false);
            //sushiScore.employeeCanvas.SetActive(true);

            //sushiScore.myTextFile.SetActive(true);



            SceneManager.LoadScene(0);

            Destroy(other.gameObject);

            //SceneManager.LoadScene("menu_scene");
        }
        else
        {
            Destroy(other.gameObject);
        }
    }


}
