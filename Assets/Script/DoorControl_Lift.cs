using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl_Lift : MonoBehaviour
{
    public GameObject door;

    bool isOpen;
    bool isSwitch;

    void Start()
    {
        isOpen = false;
        isSwitch = false;
    }
    void Update()
    {
        if (isOpen == true && isSwitch == true)
        {
            StartCoroutine(OpenDoor());
        }
        else
        {
            StopCoroutine(OpenDoor());
        }
        if (isOpen == true && isSwitch == false)
        {
            StartCoroutine(CloseDoor());
        }
        else
        {
            StopCoroutine(CloseDoor());
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
    IEnumerator OpenDoor()
    {
        door.transform.position = new Vector2(door.transform.position.x, door.transform.position.y + 1f * Time.deltaTime);
        yield return new WaitForSeconds(1.7f);
        isOpen = false;
    }
    IEnumerator CloseDoor()
    {
        door.transform.position = new Vector2(door.transform.position.x, door.transform.position.y + -1f * Time.deltaTime);
        yield return new WaitForSeconds(1.7f);
        isOpen = false;
    }
}
