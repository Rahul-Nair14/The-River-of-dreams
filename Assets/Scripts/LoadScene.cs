
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update



    public void StartGame()
    {

        this.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene(1);
        
    }

    public void EndGame()
    {
        this.GetComponent<AudioSource>().Play();
        Application.Quit();
    }

    
}
