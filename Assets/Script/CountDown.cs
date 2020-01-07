using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CountDown : MonoBehaviour
{

    public GameObject cd3;
    public GameObject cd2;
    public GameObject cd1;
    public GameObject cdgo;
    public AudioSource cd;

    public CarController car1;
    public CarController car2;
    public CarController car3;
    public CarController car4;


    public CarController carAI;
    public LapTimeManager lp;
    public BestLap bestLap;

    public AudioSource bgm;

    public void Start()
    {
        car1.GetComponent<CarController>().enabled = false;
        car2.GetComponent<CarController>().enabled = false;
        car3.GetComponent<CarController>().enabled = false;
        car4.GetComponent<CarController>().enabled = false;
        carAI.GetComponent<CarController>().enabled = false;    

        lp.GetComponent<LapTimeManager>().enabled = false;

        StartCoroutine(countDown());

        IEnumerator countDown()
        {
            yield return new WaitForSeconds(0.75f);
            cd.Play();

            yield return new WaitForSeconds(1);
            cd3.SetActive(true);

            yield return new WaitForSeconds(1);

            cd2.SetActive(true);
            yield return new WaitForSeconds(1);

            cd1.SetActive(true);
            yield return new WaitForSeconds(1);

            cdgo.SetActive(true);
            bgm.Play();
            car1.GetComponent<CarController>().enabled = true;
            car2.GetComponent<CarController>().enabled = true;
            car3.GetComponent<CarController>().enabled = true;
            car4.GetComponent<CarController>().enabled = true;

            carAI.GetComponent<CarController>().enabled = true;

            lp.GetComponent<LapTimeManager>().enabled = true;
            bestLap.GetComponent<BestLap>().enabled = true;



            yield return new WaitForSeconds(5);
            bestLap.gameObject.GetComponent<BoxCollider>().enabled = true;
            cdgo.SetActive(false);

            
        }
    }
    void Update()
    {

    }
}
