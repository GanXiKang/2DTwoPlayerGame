using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAreaControl : MonoBehaviour
{ 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player2")
        {
            collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
        }
    }
}