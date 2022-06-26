using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuMan : MonoBehaviour
{

    public Text HighScoreDisplay;

    public void Start()
    {

        GameObject.FindGameObjectWithTag("Music").GetComponent<GameMusicPlayer>().PlayMusic();

        HighScoreDisplay.text = "High Score: " + PlayerPrefs.GetInt("High Score", 0).ToString();


    }


}
