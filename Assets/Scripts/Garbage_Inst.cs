using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garbage_Inst : MonoBehaviour
{

    public GameObject[] GarbageDump;

    int randomGarbageSelect;
    public float WaitTime;

    public GameManager GM;

    public void Start()
    {

        StartCoroutine(G_Spawner());
        
    }



    void Garbage_Spawn_Controller()
    {


        randomGarbageSelect = Random.Range(0, GarbageDump.Length - 1);
        Instantiate(GarbageDump[randomGarbageSelect], new Vector3(Random.Range(-5f, 5f),Random.Range(-1f,0f),Random.Range(50f,65f)),Quaternion.identity);

    }


    IEnumerator G_Spawner()
    {

        if(GM.GameRunning == true)
        {
            while(true)
            {

                Garbage_Spawn_Controller();
                yield return new WaitForSeconds(WaitTime);

            }

        }



    }


}
