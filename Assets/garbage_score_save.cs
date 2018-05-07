using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using UnityEngine.UI;


public class garbage_score_save : MonoBehaviour {

    public SushiScore sushiScore;

    public int highScore = 0;

    public Text myText;

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
        if(other.tag == "Sushi_Salmon" || other.tag == "Sushi_Egg"){
            Destroy(other);
            sushiScore.score -= 5f;
        }
        if(other.tag == "hope"){
            Destroy(other);

            sushiScore.check = true;

            if(sushiScore.score > highScore){
                highScore = (int)sushiScore.score;
                PlayerPrefs.SetInt("highScore", (int)sushiScore.score);
            }

            sushiScore.fired.SetActive(false);

            sushiScore.throw_hope.SetActive(false);
            sushiScore.employeeCanvas.SetActive(true);

            sushiScore.myTextFile.SetActive(true);



            SceneManager.LoadScene("Scene_Final_Menu");

            //SceneManager.LoadScene("menu_scene");
        }
    }


}
