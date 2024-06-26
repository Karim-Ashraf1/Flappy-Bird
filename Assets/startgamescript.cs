using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startgamescript : MonoBehaviour
{

    public Button startButton;


    private void Awake()
    {
        Time.timeScale = 0f;
    }

    private void Start_()
    {
        // Check if the game has been played before
        bool hasPlayed = PlayerPrefs.GetInt("HasPlayed", 0) == 1;
        if (hasPlayed)
        {
            // Hide the start button
            startButton.gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        startButton.onClick.AddListener(StartGame);
    }

    private void OnDisable()
    {
        startButton.onClick.RemoveListener(StartGame);
    }

    private void StartGame()
    {
        // Set PlayerPrefs to indicate that the game has been played
        PlayerPrefs.SetInt("HasPlayed", 1);

        Time.timeScale = 1f;
        // Hide the button
        startButton.gameObject.SetActive(false);
    }

}
