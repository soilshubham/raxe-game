using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelect : MonoBehaviour
{
    // 0-red, 1-Yello, 2-Green, 3-black
    public static int carColor = 0;
    public GameObject playbutton;
    void Start()
    {
        playbutton.SetActive(true);
    }

    void Update()
    {
        
    }

    public void car01()
    {
        carColor = 0;
        playbutton.SetActive(true);

    }

    public void car02()
    {
        carColor = 1;
        playbutton.SetActive(true);

    }

    public void car03()
    {
        carColor = 2;
        playbutton.SetActive(true);

    }

    public void car04()
    {
        carColor = 3;
        playbutton.SetActive(true);

    }
}
