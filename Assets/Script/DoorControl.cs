using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    public Transform door;
    public Transform target;
    public Transform asUsual;

    private bool isOpen = false;
    
    void Update()
    {
        if (isOpen == true)
        {
            OpenDoor();
        }
        else 
        {
            CloseDoor();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (isOpen == false)
            {
                isOpen = true;
            }
            else
            {
                isOpen = false;
            }
        }
    }
    void OpenDoor()
    {
        door.transform.position = Vector3.MoveTowards(door.transform.position, target.transform.position, 0.005f);
    }
    void CloseDoor()
    {
        door.transform.position = Vector3.MoveTowards(door.transform.position, asUsual.transform.position, 0.005f);
    }
}
