using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This code allows for the charcater to be able to move based on inputs fromt he keyboards, note that there are many ways to dot his, but this is just a simple character controller to use to move things
public class Player : MonoBehaviour
{
    //implement a character controller for the character
    private CharacterController pcontroller;
    // allows for the speed or movement of the character to change 
    public float Speed = 5f;
    
    void Start()
    {
        //allows for pcharacter to get all compontents to move the character
        pcontroller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // vector3 move allows for movements to be utilized based on the vertical and horizontal inputs in the vector 3 axises
        Vector3 move = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
        //move allows the player to move by the timeing of the engine by the speed
        pcontroller.Move(move * Time.deltaTime * Speed);
    }
}
