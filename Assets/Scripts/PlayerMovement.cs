using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    Transform PlayerTransform;
    
    Vector3 mousePos;

    public GameManager gm;


    public GameObject PointSfx;
    public GameObject HitSfx;

    public float clamp = 6;
    public Camera CMcam;
    public float moveSpeed = 100f;

    public int damage1 = 5;
    public int points = 10;
    
    public void Start()
    {
       
        PlayerTransform = this.GetComponent<Transform>();

        PlayerTransform.position = new Vector3(0, 0.5f, 0);


    }
    
    public void FixedUpdate()
    {

        
        if (Input.GetMouseButton(0))

        {

            mousePos = CMcam.ScreenToWorldPoint(Input.mousePosition);

            MovementControls();

        }


        damage1 = Random.Range(7,15);

    }

    void MovementControls()
    {

        

        if (mousePos.x > 0.1 && PlayerTransform.position.x < clamp)
        {

            PlayerTransform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
            

        }
        else if (mousePos.x < 0.1 && PlayerTransform.position.x > -clamp)
        {

            PlayerTransform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0));
           
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        
        if(other.CompareTag("Obstacle"))
        {

            HitSfx.GetComponent<AudioSource>().Play();
            GameManager.CurrentHealth -= damage1;
            Destroy(other.gameObject);


        }

        if(other.CompareTag("garbage"))
        {

            PointSfx.GetComponent<AudioSource>().Play();
            gm.ScoreValue += points;
            Destroy(other.gameObject);


        }



    }



    






}
