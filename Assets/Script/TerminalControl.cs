using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerminalControl : MonoBehaviour
{
    bool isPlayer1;
    bool isPlayer2;
    void Update()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        if (isPlayer1 == true && isPlayer2 == true && coins.Length == 0)
        {
            Debug.Log("Win");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            isPlayer1 = true;
        }
        if (collision.gameObject.name == "Player2")
        {
            isPlayer2 = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            isPlayer1 = false;
        }
        if (collision.gameObject.name == "Player2")
        {
            isPlayer2 = false;
        }
    }
}
