using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;


public class WIN : MonoBehaviour
{
    public CarController car;
    public AudioSource winSound;
    public GameObject trig;
    public GameObject winCamera;

    public GameObject youWin;
    public GameObject youLose;

    void Start()
    {
        winCamera.SetActive(false);
        youWin.SetActive(false);
        youLose.SetActive(false);


    }
    void Update()
    {
        //Vector3 pos = car.gameObject.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Ronaldo")
       {
            youWin.SetActive(true);
            winCamera.SetActive(true);

            //car.m_Topspeed = 0f;
            //CarController.m_Topspeed = 0.0f;
            trig.SetActive(false);
            car.GetComponent<CarController>().enabled = false;

            car.GetComponent<CarUserControl>().enabled = false;
            winSound.Play();
            car.gameObject.SetActive(true);



        }

        if (other.gameObject.tag == "AICar")
        {
            youLose.SetActive(true);
            winCamera.SetActive(true);
            //car.m_Topspeed = 0f;
            //CarController.m_Topspeed = 0.0f;
            trig.SetActive(false);
            car.GetComponent<CarController>().enabled = false;

            car.GetComponent<CarUserControl>().enabled = false;


        }


    }
}
