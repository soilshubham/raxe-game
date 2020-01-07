using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasChange : MonoBehaviour
{

    public GameObject canvas1;
    public GameObject canvas2;
    public void MainMenu()
    {
        canvas1.SetActive(true);
        canvas2.SetActive(false);
    }

    public void PlayMenu()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(true);
    }
}
