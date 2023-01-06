using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerminalControl : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;

    bool isPlayer1;
    bool isPlayer2;

    void Update()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        if (coins.Length == 0)
        {
            StartCoroutine(OpenTerminal());
        }

        if (isPlayer1 == true && isPlayer2 == true && coins.Length == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
    IEnumerator OpenTerminal()
    {
        p1.gameObject.SetActive(false);
        p2.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        p2.gameObject.SetActive(false);
        p3.gameObject.SetActive(true);
    }
}
