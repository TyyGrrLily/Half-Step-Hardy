﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    // Use this for initialization
    public void ChangeToScene(int SceneNum)
    {
        SceneManager.LoadScene(SceneNum);
    }
}
