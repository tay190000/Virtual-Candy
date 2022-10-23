using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Prep the rigidbody variable
    Rigidbody playerRigidBody;
    GameObject diceRoll;

    // Prep direction enum
    enum direction
    {
        up,
        down,
        left,
        right
    }

    public GameObject board;
    private BoardManager B;
    int X = 0, Y = 0;



    int waiting = 0;
    int TIMER = 60;
    float MOVE = 2f;

    [SerializeField] float moveSpeed = 2500f;

    // Start is called before the first frame update
    void Start()
    {
        //Set rigid body upon creation
        playerRigidBody = GetComponent<Rigidbody>();
        B = board.GetComponent<BoardManager>();

    }

    // Update is called once per frame
    void Update()
    {   
        if(waiting == 0) {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if(canMove(direction.up)) {
                    movePlayer(direction.up);
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if(canMove(direction.down)) {
                    movePlayer(direction.down);
                }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if(canMove(direction.right)) {
                    movePlayer(direction.right);
                }
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if(canMove(direction.left)) {
                    movePlayer(direction.left);
                }
            }
        }
        else {
            waiting--;
        }
    }

    //
    void movePlayer(direction choice)
    {
        if (choice == direction.up)
        {
            Y++;
            //playerRigidBody.AddRelativeForce(0, 0, moveSpeed * Time.deltaTime);
            transform.position = transform.position + new Vector3(0, 0, MOVE);
            waiting = TIMER;
        }
        else if (choice == direction.down)
        {
            Y--;
            //playerRigidBody.AddRelativeForce(0, 0, -moveSpeed * Time.deltaTime);
            transform.position = transform.position + new Vector3(0, 0, -MOVE);
            waiting = TIMER;
        }
        else if (choice == direction.right)
        {
            X++;
            //playerRigidBody.AddRelativeForce(moveSpeed * Time.deltaTime, 0, 0);
            transform.position = transform.position + new Vector3(MOVE, 0, 0);
            waiting = TIMER;
        }
        else if (choice == direction.left)
        {
            X--;
            //playerRigidBody.AddRelativeForce(moveSpeed * -Time.deltaTime, 0, 0);
            transform.position = transform.position + new Vector3(-MOVE, 0, 0);
            waiting = TIMER;
        }
    }
    bool canMove(direction choice) {
        switch(choice) {
            case direction.up:
                if( Y < 4)
                return true;
            break;
            case direction.down:
                if( Y > 0 )
                return true;
            break;
            case direction.left:
                if( X > 0 )
                return true;
            break;
            case direction.right:
                if( X < 4 )
                return true;
            break;
        }
        return false;
    }
}
