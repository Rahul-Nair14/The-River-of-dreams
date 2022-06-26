using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Movement : MonoBehaviour
{
    Transform O_transform;
    public GameManager GM;

    public float moveSpeedobstacles = 5f;

    public float Hardener = 3f;

    


    public void Start()
    {


        O_transform = this.GetComponent<Transform>();


    }

    public void Update()
    {
        if (GM.GameRunning == true)
        {


            O_mover();


        }

        if (PlayerPrefs.GetInt("Score") < 200)
        {

            Hardener = Random.Range(1, 4);

        }
        else if(PlayerPrefs.GetInt("Score") >= 200 && PlayerPrefs.GetInt("Score") < 300)
        {

            Hardener = Random.Range(2, 5);

        }
        else
        {
            Hardener = Random.Range(1, 5);

            

        }

    }
    public void O_mover()
        {


            O_transform.Translate(new Vector3(0, 0, -moveSpeedobstacles * Hardener * Time.deltaTime));


        }



        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Destructor"))
            {

                Destroy(this.gameObject);
            }
        }
    }
