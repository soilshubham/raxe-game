﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BACKTOMENU : MonoBehaviour
{
    IEnumerator OnTriggerEnter(Collider other)
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
