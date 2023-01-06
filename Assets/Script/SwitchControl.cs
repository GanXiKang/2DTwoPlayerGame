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
            if (isP1 == true)
            {
                StartCoroutine(Up());
            }
            else
            {
                p2.gameObject.SetActive(false);
                p1.gameObject.SetActive(true);
            }
        }
    }
    IEnumerator Up()
    {
        p1.gameObject.SetActive(false);
        p2.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.4f);
        isP1 = false;
    }
}
