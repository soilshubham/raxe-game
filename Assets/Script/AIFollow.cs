using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : MonoBehaviour
{
    public GameObject[] Points;
    public GameObject tracker;
    public int pointNumber = 0;

    private void Update()
    {
        transform.position = Points[pointNumber].transform.position;

    }
    IEnumerator OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        if (other.gameObject.tag == "AICar")
        {
            pointNumber += 1;

            if(pointNumber == 15)
            {
                pointNumber = 0;
            }
        }
        yield return new WaitForSeconds(0.3f);
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
