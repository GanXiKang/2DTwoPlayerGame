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

        if (Input.GetKey("left") || Input.GetKey("right"))
        {
            anim.SetBool("Walk", true);
        }
       
    }
}
