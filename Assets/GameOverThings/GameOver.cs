﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    private int scene = 2;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
            SceneManager.LoadScene(scene);
    }
}
