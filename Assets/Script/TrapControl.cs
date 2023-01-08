using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapControl : MonoBehaviour
{
    public AudioSource bGM;
    public AudioClip die;
    public GameObject dieUI;
    public GameObject p1;
    public GameObject p2;

    public static bool player1Die = false;
    public static bool player2Die = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            StartCoroutine(Player1Died());
        }
        if (collision.gameObject.name == "Player2")
        {
            StartCoroutine(Player2Died());
        }
    }
    IEnumerator Player1Died()
    {
        bGM.PlayOneShot(die);
        player1Die = true;
        yield return new WaitForSeconds(2f);
        p1.gameObject.SetActive(false);
        Destroy(p1.gameObject);
        yield return new WaitForSeconds(1f);
        dieUI.gameObject.SetActive(true);
    }
    IEnumerator Player2Died()
    {
        bGM.PlayOneShot(die);
        player2Die = true;
        yield return new WaitForSeconds(2f);
        p2.gameObject.SetActive(false);
        Destroy(p2.gameObject);
        yield return new WaitForSeconds(1f);
        dieUI.gameObject.SetActive(true);
    }
}
