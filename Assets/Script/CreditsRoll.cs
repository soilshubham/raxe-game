using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsRoll : MonoBehaviour
{
    public GameObject credits;

    void Start()
    {
        credits.SetActive(true);
        StartCoroutine(GoBackMenu());
    }


    IEnumerator GoBackMenu()
    {
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(0);
   }
    void Update()
    {
        
    }
}
