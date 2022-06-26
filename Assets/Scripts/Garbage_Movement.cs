using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garbage_Movement : MonoBehaviour
{

    Transform G_transform;
    public GameManager GM;

    public float moveSpeed = 5f;

    public float Hardener = 3f;


    public void Start()
    {


        G_transform = this.GetComponent<Transform>();


    }

    public void Update()
    {
        if(GM.GameRunning == true)
        {


            G_mover();


        }

        if (PlayerPrefs.GetInt("Score") < 200)
        {

            Hardener = Random.Range(1, 4);

        }
        else 
        {

            Hardener = Random.Range(2, 5);

        }

    }


    public void G_mover()
    {


        G_transform.Translate(new Vector3(0, 0, -moveSpeed * Hardener * Time.deltaTime));


    }



    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destructor"))
        {

            Destroy(this.gameObject);
        }
    }
}
