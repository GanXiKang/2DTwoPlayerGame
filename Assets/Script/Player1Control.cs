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
    private Animator anim;
     void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            //anim.SetBool("Walk", true);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            bGM.PlayOneShot(j);
            transform.Translate(0, jump * Time.deltaTime, 0);
        }
    }
}
