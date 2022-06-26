using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMain : MonoBehaviour
{

    public GameObject AudioButton;
   
    public void LoadMainMenu()

    {

        SceneManager.LoadScene(0);
        Time.timeScale = 1;

    }

    public void ExitApplication()
    {
        AudioButton.GetComponent<AudioSource>().Play();
        Application.Quit();

    }
}
