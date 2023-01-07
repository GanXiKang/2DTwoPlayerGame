using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Control : MonoBehaviour
{
    public AudioSource bGM;
    public AudioClip j;

    private float speed = 5f;
    private float jump = 8f;

    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            bGM.PlayOneShot(j);
            transform.Translate(0, jump * Time.deltaTime, 0);
        }
    }
}
