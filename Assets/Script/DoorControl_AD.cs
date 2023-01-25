using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl_AD : MonoBehaviour
{
    public GameObject door;
    public Transform target;
    public Transform asUsual;

    private bool isOpen = false;
    private bool isSwitch = false;                                   //true = �_��false = �P

    void Start()
    {
        asUsual.transform.position = door.transform.position;
    }
    void Update()
    {
            if (isOpen == true && isSwitch == true)
            { 
                OpenDoor();
            }
            if (isOpen == true && isSwitch == false)
            {
                CloseDoor();
            }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            isOpen = true;

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
    void OpenDoor()
    {
        door.transform.position = Vector3.MoveTowards(door.transform.position, target.transform.position, 0.005f);
    }
    void CloseDoor()
    {
        door.transform.position = Vector3.MoveTowards(door.transform.position, asUsual.transform.position, 0.005f);
    }
}
