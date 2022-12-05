using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This code allows for the camera to move based on the inputs from the users mouse. It also follows behind the player character as it moves.
public class CameraController : MonoBehaviour
{

    //creating objects to use for our mouse, including the area it should always be behind(point), the speed of the rotation of the camera(rSpeed), and a offset foer the Vector 3. 

    public GameObject point;
    public float rSpeed = 5;
    Vector3 offset;

    void Start()
    {
        // this offset creates a  tracking system for the camera to show where it needs to be located at.
        offset = point.transform.position - transform.position;
    }

    void LateUpdate()
    {
        // allows for the horizontal axis of the mouse movement to be registered and move
        float horizontal = Input.GetAxis("Mouse X") * rSpeed;
        point.transform.Rotate(0, horizontal, 0);

        // allows for the angles of the camera to transform based on where the mouse is implemented. In otherwords, it uses math to pinpoint hwere it needs to move, in a simple and non confusing way.
        float Angle = point.transform.eulerAngles.y;
        Quaternion roter = Quaternion.Euler(0, Angle, 0);
        transform.position = point.transform.position - (roter * offset);

        transform.LookAt(point.transform);
    }
}

