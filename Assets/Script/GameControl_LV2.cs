using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl_LV2 : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown("f1"))
        {
            SceneManager.LoadScene(2);
        }
    }
}