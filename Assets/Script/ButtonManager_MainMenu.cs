using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    Animator anim;
    public GameObject camera;
    public CanvasChange canvaschange;


    public void Start()
    {
        anim = camera.GetComponent<Animator>();

    }
    public void PlayMenu()
    {
        //SceneManager.LoadScene("PlayMenu");
        anim.SetBool("PlayMenuSelect", true);
        canvaschange.PlayMenu();

    }

    public void Track01()
    {
        SceneManager.LoadScene("Track01");
    }

    public void Credits()
    {
        SceneManager.LoadScene(3);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
