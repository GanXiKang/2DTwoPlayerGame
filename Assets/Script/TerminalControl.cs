using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerminalControl : MonoBehaviour
{ 
    public AudioSource bGM;
    public AudioClip open;

    private Animator anim;

    bool isPlayer1;
    bool isPlayer2;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        if (coins.Length == 0)
        {
            StartCoroutine(TerminalIsOpen());
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
    IEnumerator TerminalIsOpen()
    {
        bGM.PlayOneShot(open);
        anim.SetBool("Open", true);
        yield return new WaitForSeconds(30f);
    }
}
