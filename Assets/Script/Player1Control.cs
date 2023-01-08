using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Control : MonoBehaviour
{
    public AudioSource bGM;
    public AudioClip j;

    private float speed = 5f;
    private float jump = 8f ;
    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKey("w"))
        {
            bGM.PlayOneShot(j);
            transform.Translate(0, jump * Time.deltaTime, 0);
        }
    }
}
