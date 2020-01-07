using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestLapDisplay : MonoBehaviour
{

    public GameObject milibox;
    public GameObject secondbox;
    public GameObject minutebox;
    void Start()
    {




    }

    void Update()
    {
        milibox.GetComponent<Text>().text = "" + PlayerPrefs.GetFloat("MiliSaveN").ToString("F0");
        secondbox.GetComponent<Text>().text = "" + PlayerPrefs.GetFloat("SecondSaveN");
        minutebox.GetComponent<Text>().text = "" + PlayerPrefs.GetFloat("MinuteSaveN");
    }
}
