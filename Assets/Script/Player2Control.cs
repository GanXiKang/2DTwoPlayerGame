using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Control : MonoBehaviour
{
    public AudioSource bGM;
    public AudioClip j;

    private float speed = 5f;
    private float jump = 7f;
    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKeyDown("up"))
        {
            bGM.PlayOneShot(j);
            Vector2 jumpHigh = new Vector2(0, jump);
            rb2D.velocity = Vector2.up * jumpHigh;
        }
    }
}
