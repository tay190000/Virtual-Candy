using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceText : MonoBehaviour
{
    Text text;
    public static int diceNumber;
    public static int prevNumber;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        prevNumber = -1;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = diceNumber.ToString();

        if (prevNumber != diceNumber)
        {
            Debug.Log("Current Dice Number: " + diceNumber.ToString());
        }

        prevNumber = diceNumber;

    }
}
