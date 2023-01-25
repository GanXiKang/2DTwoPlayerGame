using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl_AD : MonoBehaviour
{
    public GameObject door;
    public Transform target;
    public Transform asUsual;

    private bool isOpen = false;
    private bool isSwitch = false;                                   //true = È_£ªfalse = ÍP

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
    //IEnumerator OpenDoor()
    //{
    //    door.transform.position = new Vector2(door.transform.position.x + -1f * Time.deltaTime, door.transform.position.y);
    //    yield return new WaitForSeconds(2.4f);
    //    isOpen = false;
    //}
    //IEnumerator CloseDoor()
    //{
    //    door.transform.position = new Vector2(door.transform.position.x + 1f * Time.deltaTime, door.transform.position.y);
    //    yield return new WaitForSeconds(2.4f);
    //    isOpen = false;
    //}
    void OpenDoor()
    {
        door.transform.position = Vector3.MoveTowards(door.transform.position, target.transform.position, 0.005f);
    }
    void CloseDoor()
    {
        door.transform.position = Vector3.MoveTowards(door.transform.position, asUsual.transform.position, 0.005f);
    }
}
