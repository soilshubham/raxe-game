using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject car;



    void Update()
    { 

        transform.eulerAngles = new Vector3(0, car.transform.eulerAngles.y, 0);
    }
}
