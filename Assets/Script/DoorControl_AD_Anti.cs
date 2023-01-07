using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl_AD_Anti : MonoBehaviour
{
    public GameObject door;

    bool isOpen = false;
    bool isSwitch = false;                                   //true = È_£ªfalse = ÍP

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
        door.transform.position = new Vector2(door.transform.position.x + 1f * Time.deltaTime, door.transform.position.y);
        yield return new WaitForSeconds(2.4f);
        isOpen = false;
    }
    IEnumerator CloseDoor()
    {
        door.transform.position = new Vector2(door.transform.position.x + -1f * Time.deltaTime, door.transform.position.y);
        yield return new WaitForSeconds(2.4f);
        isOpen = false;
    }
}
