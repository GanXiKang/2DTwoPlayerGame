using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2AnimationControl : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private Animator anim;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        anim.SetBool("Walk", false);

        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            anim.SetBool("Walk", true);
        }
    }
}
