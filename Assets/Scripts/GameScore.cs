﻿using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class GameScore : MonoBehaviour
    {
        public PlayerMovement player;
        public Text scoreText;

        private float lastPlayerPosition;

        private void Start()
        {
            GameManager.Get().GameEnded += OnGameEnded;
            lastPlayerPosition = CurrentPlayerZ;
        }

        private void OnGameEnded(object sender, System.EventArgs e)
        {
            var score = GameData.Instance.score;
            var highscore = GameData.Instance.UpdateHighscore();
            scoreText.text = string.Format(
                "Game Over!\nScore: {0}\nHigh Score: {1}",
                score.ToIntegerString(),
                highscore.ToIntegerString());
        }

        private void FixedUpdate()
        {
            if (player != null && player.enabled)
            {
                UpdatePlayerScore();
                scoreText.text = GameData.Instance.score.ToIntegerString();
            }
        }

        private void UpdatePlayerScore()
        {
            var distancePassed = CurrentPlayerZ - lastPlayerPosition;
            GameData.Instance.score += Math.Max(0, distancePassed);
            lastPlayerPosition = CurrentPlayerZ;
        }

        private float CurrentPlayerZ
        {
            get
            {
                return player.transform.position.z;
            }
        }
    }
}