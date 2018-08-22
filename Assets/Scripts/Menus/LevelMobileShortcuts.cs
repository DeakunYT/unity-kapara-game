﻿using Assets.Scripts;
using Assets.Scripts.Menus;
using UnityEngine;

public class LevelMobileShortcuts : MenuShortcuts
{
    void Start()
    {
        if (Utilities.Platform != Utilities.PlatformType.Mobile)
        {
            enabled = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.Get().ShowPauseMenu();
        }
    }
}
