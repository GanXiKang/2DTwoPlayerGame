using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene(1);
    }
    public void HowToPlay()
    {
        
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Menu() 
    {
        SceneManager.LoadScene(0);
    }
}
