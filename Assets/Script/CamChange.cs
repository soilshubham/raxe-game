using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange : MonoBehaviour
{

    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;

    public int camNum=0;
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);

    }

    void Update()
    {
        StartCoroutine(camCHANGE());
    }

    IEnumerator camCHANGE()
    {
        if (Input.GetKeyDown("c"))
        {
            yield return new WaitForSeconds(0.01f);

            camNum += 1;
        }
        if (camNum > 3)
        {
            camNum = 0;
        }

        if (camNum == 0)
        {
            //yield return new WaitForSeconds(0.3f);

            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);

        }

        if (camNum == 1)
        {
            //yield return new WaitForSeconds(0.3f);

            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            cam4.SetActive(false);

        }

        if (camNum == 2)
        {
            //yield return new WaitForSeconds(0.3f);

            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
            cam4.SetActive(false);

        }

        if (camNum == 3)
        {
            //yield return new WaitForSeconds(0.3f);

            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(true);

        }
    }
}
