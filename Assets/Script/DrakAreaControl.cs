using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrakAreaControl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);
        }
    }
}
