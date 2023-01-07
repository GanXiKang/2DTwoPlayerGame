using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapControl : MonoBehaviour
{
    public AudioSource bGM;
    public AudioClip die;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            bGM.PlayOneShot(die);
            collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
        }
    }
}
