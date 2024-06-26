using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class logicscript : MonoBehaviour
{
    public int playerscore;
    public Text scoretext;
    public Text highscore;
    public GameObject gameoverscreen;
    public GameObject startgamescreen;
    public AudioSource point;
    public AudioSource die;
    public AudioSource hit;
    public AudioSource flap;
 

    public void addscore(int scoreToAdd)
    {
        playerscore += scoreToAdd;
        scoretext.text = playerscore.ToString();
        
    }
    /////////////////////////////////////////////////

    public void pointplay()
    {
        point.Play();
    }


    public void dieplay()
    {
        die.Play();
    }

    public void hitplay()
    {
        hit.Play();
    }

    public void flapplay()
    {
        flap.Play();
    }




    ///////////////////////////////////////////////////

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }
    /////////////////////////////////////////////////

    public void StarttheGame()
    {
        SceneManager.LoadScene("difficulty");
    }


    ////////////////////////////////////////////////////

    public void Quitgame()
    {
         Debug.Log("Quit");
        Application.Quit();
    }
////////////////////////////////////////////////////


    // Start is called before the first frame update
    void Start_()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
           
            PauseGame();
        }
    }

    ///////////////////////////////////////////

    public void easy()
    {
        
        SceneManager.LoadScene("easy");
    }

    public void medium()
    {
       
        SceneManager.LoadScene("medium");
    }

    public void hard()
    {
       
        SceneManager.LoadScene("hard");
    }

    public void mainmenu()
    {
       
        SceneManager.LoadScene("startgame");
    }

/////////////////////////////////////////////////

    private bool isPaused = false;

    public void PauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0f;
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1f;
            isPaused = false;
        }
    }
    //////////////////////////////////////////////

    
}
