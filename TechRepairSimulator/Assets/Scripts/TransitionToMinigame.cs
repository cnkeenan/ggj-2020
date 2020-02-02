﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TransitionToMinigame : MonoBehaviour
{
    public bool locked = true;
    void OnMouseDown()
    {
        var anim = GetComponentInChildren<Animator>();

        if (anim.GetBool("Hold") && !locked)
        {
            SceneManager.LoadScene("SC02");
        }
    }
}
