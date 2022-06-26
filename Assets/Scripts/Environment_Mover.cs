using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 
/// Moves the environments smoothly one after the other and destroys environment on collision with E_destroyer
/// 
/// </summary>

public class Environment_Mover : MonoBehaviour
{


    public GameManager GM;
    public float E_Speed = 5f;
    public GameObject E_Destroyer;

    Transform E_Transform;

    public void Start()
    {

        E_Transform = this.GetComponent<Transform>();
        
    }


    public void Update()
    {

        if (GM.GameRunning == true)
        {

            E_Mover();
        
        }


    }


    void E_Mover()
    {

        E_Transform.Translate(0, 0, -E_Speed * Time.deltaTime);

    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Destroyer"))
        {

            Destroy(this.gameObject);
        }
    }

}
