using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Script : MonoBehaviour
{
    public static bool WIN = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player_Movement.X == 8 && Player_Movement.Y == 8) {

            ChallengeText.challengetext = "WINNER!";
            WIN = true;
        }
    }
}
