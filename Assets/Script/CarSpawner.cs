using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{

    public GameObject redcar;
    public GameObject yellowcar;
    public GameObject greencar;
    public GameObject blackcar;


    void Start()
    {
        if(CarSelect.carColor == 0)
        {
            redcar.SetActive(true);
            yellowcar.SetActive(false);
            greencar.SetActive(false);
            blackcar.SetActive(false);
        }

        if (CarSelect.carColor == 1)
        {
            redcar.SetActive(false);
            yellowcar.SetActive(true);
            greencar.SetActive(false);
            blackcar.SetActive(false);
        }

        if (CarSelect.carColor == 2)
        {
            redcar.SetActive(false);
            yellowcar.SetActive(false);
            greencar.SetActive(true);
            blackcar.SetActive(false);
        }

        if (CarSelect.carColor == 3)
        {
            redcar.SetActive(false);
            yellowcar.SetActive(false);
            greencar.SetActive(false);
            blackcar.SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
