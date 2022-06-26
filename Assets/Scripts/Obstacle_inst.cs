using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_inst : MonoBehaviour
{

    public GameObject[] ObstacleDump;

    int randomObstacleSelect;
    public float WaitTime;

    public GameManager GM;

    public void Start()
    {

        StartCoroutine(O_Spawner());

    }

    void Obstacle_Spawn_Controller()
    {


        randomObstacleSelect = Random.Range(0, ObstacleDump.Length - 1);
        Instantiate(ObstacleDump[randomObstacleSelect], new Vector3(Random.Range(-5f, 5f), Random.Range(0f, 1f), Random.Range(50f, 65f)), Quaternion.identity);

    }


    IEnumerator O_Spawner()
    {

        if (GM.GameRunning == true)
        {
            while (true)
            {

                Obstacle_Spawn_Controller();
                yield return new WaitForSeconds(WaitTime);

            }

        }



    }



}
