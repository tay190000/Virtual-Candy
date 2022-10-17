using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Prep the rigidbody variable
    Rigidbody playerRigidBody;

    // Prep direction enum
    enum direction
    {
        up,
        down,
        left,
        right
    }

    [SerializeField] float moveSpeed = 2500f;

    // Start is called before the first frame update
    void Start()
    {
        //Set rigid body upon creation
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            movePlayer(direction.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movePlayer(direction.down);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movePlayer(direction.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movePlayer(direction.left);
        }
    }

    //
    void movePlayer(direction choice)
    {
        if (choice == direction.up)
        {
            playerRigidBody.AddRelativeForce(0, 0, moveSpeed * Time.deltaTime);
        }
        else if (choice == direction.down)
        {
            playerRigidBody.AddRelativeForce(0, 0, -moveSpeed * Time.deltaTime);
        }
        else if (choice == direction.right)
        {
            playerRigidBody.AddRelativeForce(moveSpeed * Time.deltaTime, 0, 0);
        }
        else if (choice == direction.left)
        {
            playerRigidBody.AddRelativeForce(moveSpeed * -Time.deltaTime, 0, 0);
        }
    }
}
