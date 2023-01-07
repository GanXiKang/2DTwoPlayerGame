using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAreaControl : MonoBehaviour
{
    public AudioSource bGM;
    public AudioClip die;
    public GameObject dieUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player2")
        {
            bGM.PlayOneShot(die);
            collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
            StartCoroutine(PlayerDied());
        }
    }
    IEnumerator PlayerDied()
    {
        yield return new WaitForSeconds(3f);
        dieUI.gameObject.SetActive(true);
    }
}
