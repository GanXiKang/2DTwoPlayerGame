using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimationControl : MonoBehaviour
{
    private Animator anim;

    bool isSwitch = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (isSwitch == true)
        {
            anim.SetBool("open", true);
        }
        else
        {
            anim.SetBool("open", false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (isSwitch == false)
            {
                isSwitch = true;
            }
            else
            {
                isSwitch = false;
            }
        }
    }
}
