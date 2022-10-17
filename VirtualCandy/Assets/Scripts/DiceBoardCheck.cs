using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceBoardCheck : MonoBehaviour
{
    Vector3 diceVelocity;

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
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            switch (collider.gameObject.name)
            {
                case "Side1":
                    DiceText.diceNumber = 6;
                    break;
                case "Side2":
                    DiceText.diceNumber = 5;
                    break;
                case "Side3":
                    DiceText.diceNumber = 4;
                    break;
                case "Side4":
                    DiceText.diceNumber = 3;
                    break;
                case "Side5":
                    DiceText.diceNumber = 2;
                    break;
                case "Side6":
                    DiceText.diceNumber = 1;
                    break;
            }
        }
    }
}
