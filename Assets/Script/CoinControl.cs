using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{
    public AudioSource bGM;
    public AudioClip coin;

    void Update()
    {
        transform.Rotate(0, 45f * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            bGM.PlayOneShot(coin);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
