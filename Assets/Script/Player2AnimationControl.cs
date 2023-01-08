using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2AnimationControl : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
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
