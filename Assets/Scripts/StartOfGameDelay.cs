﻿using Assets.Scripts.Audio;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class StartOfGameDelay : MonoBehaviour
    {
        public PlayerMovement player;
        public int delay = 3;
        public string postCountdownText = "Get ready...";
        public string gameStartText = "GO!";
        public Text ui;

        void Start()
        {
            StartCoroutine("Run");
        }

        IEnumerator Run()
        {
            AudioManager.Instance.StopAllPlayingSounds();
            AudioManager.Instance.Play("LevelsMusic");
            player.enabled = false;

            for (int i = delay; i > 0; i--)
            {
                ui.text = string.Format("{0}...", i);
                yield return new WaitForSeconds(1f);
            }

            ui.text = postCountdownText;
            yield return new WaitForSeconds(1f);

            ui.text = gameStartText;
            yield return new WaitForSeconds(1f);

            player.enabled = true;
        }
    }
}