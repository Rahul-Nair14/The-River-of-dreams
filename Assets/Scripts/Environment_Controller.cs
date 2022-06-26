using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment_Controller : MonoBehaviour
{
    // Start is called before the first frame update

    /// <summary>
    /// 
    /// Spawns the different environments in random patterns
    /// 
    /// </summary>

    public GameObject[] EnvironmentArray;
    int Envi_randomizer;


    public float SpawnLoc = 89.9f;
    public float WaitingTime = 7f;
    public GameManager GM;



    public void Start()
    {
        StartCoroutine(E_Spawner());
    }



    void Environment_Spawn_Controller()
    {
        Envi_randomizer = Random.Range(0, EnvironmentArray.Length-1);
        Instantiate(EnvironmentArray[Envi_randomizer], new Vector3(0, 2.6f, SpawnLoc), Quaternion.identity);
     

    }


    IEnumerator E_Spawner()
    {

        if (GM.GameRunning == true)
        {
            while (true)
            {

                Environment_Spawn_Controller();
                yield return new WaitForSeconds(WaitingTime);

            }
        }

        


    }


}
