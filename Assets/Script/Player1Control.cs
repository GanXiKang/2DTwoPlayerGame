using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Control : MonoBehaviour
{
    public float speed = 5f;

    private float jump = 8f ;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate(0, jump * Time.deltaTime, 0);
        }
    }
}
