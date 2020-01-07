using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackSelect : MonoBehaviour
{
    public static int trackNum = 1;
    public GameObject carSelect;
    public GameObject playbutton;

    void Start()
    {
        carSelect.SetActive(false);
        playbutton.SetActive(false);

    }
    void Update()
    {
        
    }

    public void Track01()
    {
        trackNum = 1;
        carSelect.SetActive(true);

    }

    public void Track02()
    {
        trackNum = 2;
        carSelect.SetActive(true);


    }
}
