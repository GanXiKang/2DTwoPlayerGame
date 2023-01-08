using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl_LV3 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("f1"))
        {
            SceneManager.LoadScene(3);

            LightAreaControl.player2Die = false;
            DrakAreaControl.player1Die = false;
            TrapControl.player1Die = false;
            TrapControl.player2Die = false;
        }
    }
}
