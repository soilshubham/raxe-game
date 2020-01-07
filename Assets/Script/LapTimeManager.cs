using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LapTimeManager : MonoBehaviour
{
    public static int minuteCount;
    public static int secondCount;
    public static float miliCount;
    public static string miliDisplay;

    public GameObject minuteBox;
    public GameObject secondBox;
    public GameObject miliBox;

    public static float rawTime;



    void Update()
    {
        miliCount += Time.deltaTime * 10;

        rawTime += Time.deltaTime;                          //<===

        miliDisplay = miliCount.ToString("F0");

        miliBox.GetComponent<Text>().text = miliDisplay;

        if(miliCount >= 9)
        {
            miliCount = 0;
            secondCount += 1;
        }

        if(secondCount <= 9)
        {
            secondBox.GetComponent<Text>().text = "0" + secondCount;
        }
        else
        {
            secondBox.GetComponent<Text>().text = "" + secondCount;

        }

        if(secondCount >= 60)
        {
            secondCount = 0;
            minuteCount += 1;
        }
        if (minuteCount <= 9)
        {
            minuteBox.GetComponent<Text>().text = "0" + minuteCount;
        }
        else
        {
            minuteBox.GetComponent<Text>().text = "" + minuteCount;

        }


    }
}
