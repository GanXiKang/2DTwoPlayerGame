using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1AnimationControl : MonoBehaviour
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
        Flip();

        anim.SetBool("Walk", false);

        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            anim.SetBool("Walk", true);
        }
    }
    void Flip()
    {
        
        if (Input.GetKey("a"))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
