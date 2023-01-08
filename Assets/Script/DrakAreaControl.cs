using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrakAreaControl : MonoBehaviour
{
    public AudioSource bGM;
    public AudioClip die;
    public GameObject dieUI;
    public GameObject p1;

    public static bool player1Die = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            
            StartCoroutine(PlayerDied());
        }
    }
    IEnumerator PlayerDied()
    {
        bGM.PlayOneShot(die);
        player1Die = true;
        yield return new WaitForSeconds(2f);
        p1.gameObject.SetActive(false);
        Destroy(p1.gameObject);
        yield return new WaitForSeconds(1f);
        dieUI.gameObject.SetActive(true);
    }
}
