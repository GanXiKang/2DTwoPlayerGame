using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimationControl : MonoBehaviour
{
    public AudioSource bGM;
    public AudioClip sw;

    private Animator anim;

    private bool isSwitchDown = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (isSwitchDown == true)
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
            bGM.PlayOneShot(sw);
            if (isSwitchDown == false)
            {
                isSwitchDown = true;
            }
            else
            {
                isSwitchDown = false;
            }
        }
    }
}
