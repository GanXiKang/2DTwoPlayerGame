using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Try_MoveToWord : MonoBehaviour
{
    public Transform target;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.05f);
    }
}
