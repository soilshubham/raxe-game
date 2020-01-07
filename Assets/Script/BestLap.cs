using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestLap : MonoBehaviour
{
    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject miliBox;

    public float miliSave;
    public int secondSave;
    public int minuteSave;

    public float RawTime;


    public float counter;
    //public BestLap bestLap;
    public float lapCounter1;
    public float lapCounter2 = 500;


    public void SaveLapTime()
    {

        miliBox.GetComponent<Text>().text = LapTimeManager.miliDisplay;

        if (LapTimeManager.secondCount <= 9)
        {
            secondBox.GetComponent<Text>().text = "0" + LapTimeManager.secondCount;
        }
        else
        {
            secondBox.GetComponent<Text>().text = "" + LapTimeManager.secondCount;

        }

        if (LapTimeManager.secondCount >= 60)
        {
            LapTimeManager.secondCount = 0;
            LapTimeManager.minuteCount += 1;
        }
        if (LapTimeManager.minuteCount <= 9)
        {
            minuteBox.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount;
        }
        else
        {
            minuteBox.GetComponent<Text>().text = "" + LapTimeManager.minuteCount;

        }
    }

        
        
    
    private void Start()
    {

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ronaldo")
        {
            RawTime = PlayerPrefs.GetFloat("RawTime");
            if (LapTimeManager.rawTime <= RawTime)
            {
                SaveLapTime();


                PlayerPrefs.SetFloat("MiliSaveN", LapTimeManager.miliCount);
                PlayerPrefs.SetFloat("SecondSaveN", LapTimeManager.secondCount);
                PlayerPrefs.SetFloat("MinuteSaveN", LapTimeManager.minuteCount);
                PlayerPrefs.SetFloat("RawTime", LapTimeManager.rawTime);
            }


            LapTimeManager.minuteCount = 0;
            LapTimeManager.secondCount = 0;
            LapTimeManager.miliCount = 0;
            LapTimeManager.rawTime = 0;

        }
    }

}
