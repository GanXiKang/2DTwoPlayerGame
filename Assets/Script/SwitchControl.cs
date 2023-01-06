using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControl : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;

    bool isP1 = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (isP1)
            {
                p1.gameObject.SetActive(false);
                p2.gameObject.SetActive(true);
                isP1 = false;
            }
            else
            {
                p2.gameObject.SetActive(false);
                p1.gameObject.SetActive(true);
                isP1 = true;
            }
        }
    }
}
