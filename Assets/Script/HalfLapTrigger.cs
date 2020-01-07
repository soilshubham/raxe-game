using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfLapTrigger : MonoBehaviour
{
    public GameObject halfLapTrigger;
    public GameObject finishtrigger;
    public FinishPostEnable finishPostEnable;


    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (LapCompleteTrigger.lapCount == LapCompleteTrigger.lapToWin - 1)
        {
            finishPostEnable.finishPostEnable();
        }

        if (col.gameObject.tag == "Ronaldo")
        {
            finishtrigger.SetActive(true);
            halfLapTrigger.SetActive(false);
        }
        if(col.gameObject.tag == "AICar")
        {
           
        }
    }
}
