using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPostEnable : MonoBehaviour
{
    public GameObject finishPost;
    public GameObject line;

    private void Start()
    {
        finishPost.SetActive(false);
    }
    public void finishPostEnable()
    {
        finishPost.SetActive(true);
        line.SetActive(false);
    }
}
