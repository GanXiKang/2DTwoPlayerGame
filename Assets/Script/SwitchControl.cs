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
                StopCoroutine(Down());
                StartCoroutine(Up());
            }
            else
            {
                StopCoroutine(Up());
                StartCoroutine(Down());
            }
        }
    }
    IEnumerator Up()
    {
        p1.gameObject.SetActive(false);
        p2.gameObject.SetActive(true);
        Debug.Log("wait");
        isP1 = true;
        yield return new WaitForSeconds(2.4f);
        Debug.Log("ok");
        isP1 = false;
    }
    IEnumerator Down()
    {
        p2.gameObject.SetActive(false);
        p1.gameObject.SetActive(true);
        Debug.Log("wait");
        isP1 = false;
        yield return new WaitForSeconds(2.4f);
        Debug.Log("ok");
        isP1 = true;
    }
}
