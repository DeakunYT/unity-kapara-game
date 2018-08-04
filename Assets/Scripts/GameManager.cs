﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Editor Variables

    public float restartDelay = 3f;
    public event EventHandler GameEnded;
    public GameObject completeLevelUi;
    public ObstaclesGenerator obstacles;

    #endregion Editor Variables

    #region Implementation Variable

    private bool gameHasEnded = false;

    #endregion

    public static GameManager Get()
    {
        return FindObjectOfType<GameManager>();
    }

    #region Public API

    public void LoadNextLevel()
    {
        var currentSceneBuildIndex = SceneManager.GetActiveScene().buildIndex;
        var nextSceneBuildIndex = currentSceneBuildIndex + 1;
        Debug.LogFormat("Current Scene Index: {0}, Next Scene Index: {1}",
            currentSceneBuildIndex, nextSceneBuildIndex);
        SceneManager.LoadScene(nextSceneBuildIndex);
    }

    public void CompleteLevel()
    {
        completeLevelUi.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded)
        {
            return;
        }

        gameHasEnded = true;
        GameEnded.Invoke(null, null);
        Invoke("RestartGame", restartDelay);
    }

    #endregion Public API

    #region Implementation

    private void RestartGame()
    {
        LoadScene(0);
    }

    private void LoadScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
        var newScene = SceneManager.GetSceneByBuildIndex(buildIndex);
        Debug.Log("Loaded Scene: " + newScene.name);
        obstacles.GenerateObstacles();
        gameHasEnded = false;
    }

    #endregion Implementation
}
