﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene("SC01");
    }
}