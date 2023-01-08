using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl_LV1 : MonoBehaviour
{ 
    void Update()
    {
        if (Input.GetKeyDown("f1"))
        {
            SceneManager.LoadScene(1);

            LightAreaControl.player2Die = false;
            DrakAreaControl.player1Die = false;
            TrapControl.player1Die = false;
            TrapControl.player2Die = false;
        }
    }
}
