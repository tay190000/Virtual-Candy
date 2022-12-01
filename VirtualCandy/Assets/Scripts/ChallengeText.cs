using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChallengeText : MonoBehaviour
{
    public static string challengetext = "";
    public Text theText;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        theText.text = challengetext;
    }
}
