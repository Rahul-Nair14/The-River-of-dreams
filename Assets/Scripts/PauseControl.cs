using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseControl : MonoBehaviour
{

    public GameObject PauseCanvas;
    public Text ScoreObj;
    public GameManager GM;
    public GameObject Audiobutton;

    public void PausingGame()
    {
        Audiobutton.GetComponent<AudioSource>().Play();
        Time.timeScale = 0;
        PauseCanvas.SetActive(true);
        ScoreObj.text = "Score: " + GM.ScoreValue.ToString();
        
    }

    public void ResumingGame()
    {
        Audiobutton.GetComponent<AudioSource>().Play();
        Time.timeScale = 1;
        PauseCanvas.SetActive(false);

    }

    
}
