using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SushiSpawn : MonoBehaviour
{

    public GameObject[] sushiPrefabs;



    //public GameObject sushi1;
    //public GameObject sushi2;
    //public GameObject sushi3;
    //public GameObject sushi4;
    //public GameObject sushi5;

    public Transform[] sushiSpawns;

    //public Transform spawn1;
    //public Transform spawn2;
    //public Transform spawn3;
    //public Transform spawn4;
    //public Transform spawn5;

    public float timeCount = 2f;
    public float timeAccel;

	// Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        timeCount -= Time.deltaTime;
        //timeAccel = Mathf.Log(timeCount);

        if(timeAccel < 1.5f){
            timeAccel += (Time.deltaTime) / (60f);
        }

        if(timeCount <= 0f){

            // (int i = 0; i <= checker; i++){

                Random.Range(1, 5);
                Random.Range(1, 5);

                //Transform mySpawn = Spawner();

                //GameObject myObj = Objector();

                GameObject randSushi = sushiPrefabs[Random.Range(0, sushiPrefabs.Length)];
                Transform mySpawn = sushiSpawns[Random.Range(0, sushiSpawns.Length)];

                Instantiate(randSushi, mySpawn.position, Quaternion.identity);
          //  }

            timeCount = 2f - timeAccel;
        }

	}


    //public GameObject Objector(int myInt)
    //{
    //    if(myInt == 1){
    //        return sushi1;
    //    }

    //    else if (myInt == 2)
    //    {
    //        return sushi2;
    //    }

    //    else if (myInt == 3)
    //    {
    //        return sushi3;
    //    }

    //    else if (myInt == 4)
    //    {
    //        return sushi4;
    //    }

    //    else
    //    {
    //        return sushi5;
    //    }



    //}

    //public Transform Spawner(int myInt)
    //{
        //if (myInt == 1)
        //{
        //    return spawn1;
        //}

        //else if (myInt == 2)
        //{
        //    return spawn2;
        //}

        //else if (myInt == 3)
        //{
        //    return spawn3;
        //}

        //else if (myInt == 4)
        //{
        //    return spawn4;
        //}

        //else
        //{
        //    return spawn5;
        //}



//    }
}
