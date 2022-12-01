using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Prep the rigidbody variable
    Rigidbody playerRigidBody;
    GameObject diceRoll;
    public static int totalPlayerMovement = 0;
    public static bool allowPlayerMovement = false;
    public static bool SHOWTEXT = false;

    // Prep direction enum
    enum direction
    {
        up,
        down,
        left,
        right
    }

    // Blowpop coords
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
       //B = board.GetComponent<BoardManager>();

    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(10);
        Dice.rollAgain = true;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Waiting: Number of player movements: " + totalPlayerMovement);
        if (waiting == 0) {
            Debug.Log("After Waiting: Number of player movements: " + totalPlayerMovement);
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if(totalPlayerMovement > 0 && canMove(direction.up)) {
                    movePlayer(direction.up);
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if(totalPlayerMovement > 0 && canMove(direction.down)) {
                    movePlayer(direction.down);
                }
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if(totalPlayerMovement > 0 && canMove(direction.right)) {
                    movePlayer(direction.right);
                }
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if(totalPlayerMovement > 0 && canMove(direction.left)) {
                    movePlayer(direction.left);
                }
            }
            if(Input.GetKeyDown(KeyCode.Return) && SHOWTEXT) {
                SHOWTEXT = false;
                Text_Background.moveUP = true;
                removeText();
            }
            if (totalPlayerMovement == 0)
            {
                StartCoroutine(Delay());
            }
        }
        else {
            waiting--;
        }
    }

    //
    void movePlayer(direction choice)
    {
        Debug.Log("Number of player movements: " + totalPlayerMovement);

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

        totalPlayerMovement--;

        if (totalPlayerMovement == 0)
        {
            displayText();
            Text_Background.moveDOWN = true;
            Dice.rollAgain = true;
            allowPlayerMovement = false;
        }

    }
    bool canMove(direction choice) {
        if(SHOWTEXT)
        {
            return false;
        }
        switch (choice) {
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
    void displayText() {
        SHOWTEXT = true;
        if(BoardManager.BOARD[X,Y] == 1) {
            ChallengeText.challengetext = BoardManager.GREEN[Random.Range(0,1)];
        }
        else if (BoardManager.BOARD[X,Y] == 2) {
            ChallengeText.challengetext = BoardManager.RED[Random.Range(0,1)];
        }
        else {
            return;
        }
    }
    void removeText() {
        ChallengeText.challengetext = "";
    }
}
