using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceBoardCheck : MonoBehaviour
{
    Vector3 diceVelocity;
    public static bool rolledAgain = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    private void FixedUpdate()
    {
        diceVelocity = Dice.diceVelocity;
    }

    private void OnTriggerStay(Collider collider)
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f && rolledAgain)
        {
            switch (collider.gameObject.name)
            {
                case "Side1":
                    DiceText.diceNumber = 6;
                    Player_Movement.totalPlayerMovement = 6;
                    Player_Movement.allowPlayerMovement = true;
                    rolledAgain = false;
                    break;
                case "Side2":
                    DiceText.diceNumber = 5;
                    Player_Movement.totalPlayerMovement = 5;
                    Player_Movement.allowPlayerMovement = true;
                    rolledAgain = false;
                    break;
                case "Side3":
                    DiceText.diceNumber = 4;
                    Player_Movement.totalPlayerMovement = 4;
                    Player_Movement.allowPlayerMovement = true;
                    rolledAgain = false;
                    break;
                case "Side4":
                    DiceText.diceNumber = 3;
                    Player_Movement.totalPlayerMovement = 3;
                    Player_Movement.allowPlayerMovement = true;
                    rolledAgain = false;
                    break;
                case "Side5":
                    DiceText.diceNumber = 2;
                    Player_Movement.totalPlayerMovement = 2;
                    Player_Movement.allowPlayerMovement = true;
                    rolledAgain = false;
                    break;
                case "Side6":
                    DiceText.diceNumber = 1;
                    Player_Movement.totalPlayerMovement = 1;
                    Player_Movement.allowPlayerMovement = true;
                    rolledAgain = false;
                    break;
            }
        }
    }
}
