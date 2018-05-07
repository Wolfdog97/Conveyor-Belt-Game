using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;


public class garbage_score_save : MonoBehaviour {

    public SushiScore sushiScore;
    public Text myText;

    public List<float> myfloats = new List<float>{};

	// Use this for initialization
	void Start () {
		
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

            //float doggy_dog_world = sushiScore.score;
            //float doggy_dog_world2;

            //for (int i = 0; i <= myfloats.Length; i++){
            //    if(myfloats[i] < doggy_dog_world){
            //        doggy_dog_world2 = myfloats[i];
            //        myfloats[i] = doggy_dog_world;
            //        doggy_dog_world = doggy_dog_world2;
            //    }
            //}

            //myfloats.Add(doggy_dog_world);

            myfloats.Add(sushiScore.score);
            List<float> Sort_Scores = myfloats.OrderBy(x => x).ToList();

            myText = myText + "\n$" + (string)sushiScore.score; //myText will later become highscore manager
            //SceneManager.LoadScene("menu_scene");
        }
    }


}
