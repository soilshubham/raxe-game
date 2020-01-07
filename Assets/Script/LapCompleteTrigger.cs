using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapCompleteTrigger : MonoBehaviour
{
    public GameObject halfLapTrigger;
    public GameObject finishtrigger;
    public static float lapCount = 0;
    public static bool lapFinish=false;
    public static int lapToWin = 2;



    private void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Ronaldo")
        {
            finishtrigger.SetActive(false);
            halfLapTrigger.SetActive(true);
            lapCount += 1;
        }

    }
}
