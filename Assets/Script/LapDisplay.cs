using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapDisplay : MonoBehaviour
{
    public GameObject lapDisplay;
    void Update()
    {
        lapDisplay.GetComponent<Text>().text = "" + LapCompleteTrigger.lapCount;
    }
}
