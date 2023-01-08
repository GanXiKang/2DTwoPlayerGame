using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAreaControl : MonoBehaviour
{
    public AudioSource bGM;
    public AudioClip die;
    public GameObject dieUI;
    public GameObject p2;

    public static bool playerDie = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player2")
        {
            StartCoroutine(PlayerDied());
        }
    }
    IEnumerator PlayerDied()
    {
        playerDie = true;
        bGM.PlayOneShot(die);
        yield return new WaitForSeconds(2f);
        p2.gameObject.SetActive(false);
        Destroy(p2.gameObject);
        yield return new WaitForSeconds(1f);
        dieUI.gameObject.SetActive(true);
    }
}
