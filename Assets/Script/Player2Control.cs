using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Control : MonoBehaviour
{
    private float speed = 5f;
    private float jump = 7f;
    void Start()
    {
        
    }
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
            transform.Translate(0, jump * Time.deltaTime, 0);
        }
    }
}
