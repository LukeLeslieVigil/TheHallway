using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public GameObject thePlayer;
    public bool isMoving;
    public float horizontalMove;
    public float verticalMove;
    public float movementWalkSpeed;
    public float movementRunSpeed;
    public float rotationSpeed;

    private void Update()
    {
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            isMoving = true;
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
            verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * movementWalkSpeed;

            thePlayer.transform.Rotate(0, horizontalMove, 0);
            thePlayer.transform.Translate(0, 0, verticalMove);
        }
        else
        {
            isMoving = false;
        }
    }
}
