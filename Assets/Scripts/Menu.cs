using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public Canvas canvas1;
    public Canvas canvas2;

    private void Start()
    {
        canvas2.enabled = false;
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Controls()
    {
        canvas1.enabled = false;
        canvas2.enabled = true;
    }
    
    public void Back()
    {
        canvas2.enabled = false;
        canvas1.enabled = true;
    }
}
