using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;



/// <summary>
/// 
/// Controls score, life and resets game, also controls wave particle system
/// 
/// </summary>
public class GameManager : MonoBehaviour
{

    public GameObject PauseCanvas;

    public int ScoreValue = 0;
    public TMP_Text ScoreDisplay;

    public int MaxBoatHealth = 100;
    public static float CurrentHealth;
    public Image HealthBar;
    Image HealthBarIMG;

    public GameObject WaveParticles;
    Vector3 RandomWavePosition;

    public bool GameRunning = true;

    public GameObject GameOverScreen;
    public Text GameOverScore;
    

    public void Start()
    {

        GameObject.FindGameObjectWithTag("Music").GetComponent<GameMusicPlayer>().PlayMusic();

        GameOverScreen.SetActive(false);
        Time.timeScale = 1;

        ScoreValue = 0;
        HealthBarIMG = HealthBar.GetComponent<Image>();
        CurrentHealth = MaxBoatHealth;
        StartCoroutine(WaveTime());

    }

    public void FixedUpdate()
    {

        if(CurrentHealth <= 0)
        {

            this.GetComponent<AudioSource>().Play();
            Time.timeScale = 0;
            GameOverScreen.SetActive(true);

        }

        



        ScoreDisplay.text = ScoreValue.ToString();
        HealthBarIMG.fillAmount = CurrentHealth / MaxBoatHealth;

        GameOverScore.text = "Score: " + ScoreValue.ToString();



        if(ScoreValue > PlayerPrefs.GetInt("High Score",0))
        {

            PlayerPrefs.SetInt("High Score", ScoreValue);


        }

        PlayerPrefs.SetInt("Score", ScoreValue);


    }




    public void SpawnWaves()
    {

        RandomWavePosition = new Vector3(Random.Range(-3.5f, 3.5f), 0.1f, Random.Range(10f, 40f));
        Instantiate(WaveParticles, RandomWavePosition, Quaternion.identity);
        
    }
    
    IEnumerator WaveTime()
    {
        while(true)
        {

            SpawnWaves();
            yield return new WaitForSeconds(2.5f);
        }

    }

      
       
 

}
