using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager_PlayMenu : MonoBehaviour
{
    Animator anim;
    public GameObject camera;
    public CanvasChange canvaschange;

    public void Start()
    {
        anim = camera.GetComponent<Animator>();

    }
    public void Back()
    {
        anim.SetBool("PlayMenuSelect", false);

        canvaschange.MainMenu();
    }

    public void Play()
    {
        anim.SetBool("PlayMenuSelect", false);

        canvaschange.MainMenu();
    }


}
