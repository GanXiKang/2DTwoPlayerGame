using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrakAreaControl : MonoBehaviour
{
    public AudioSource bGM;
    public AudioClip die;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            bGM.PlayOneShot(die);
            collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
        }
    }
}
