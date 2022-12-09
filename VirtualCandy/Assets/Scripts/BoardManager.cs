using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour
{
    public static int[,] BOARD = {{0,2,1,1,2,1,1,2,2},{1,1,2,2,1,2,2,1,2},{2,2,1,2,2,1,2,2,1},{1,1,2,1,1,2,1,1,2},{2,2,1,2,2,2,1,1,1},{1,1,1,2,2,1,1,2,2},{2,1,2,1,2,2,1,2,1},{2,2,1,2,2,2,1,1,1},{2,1,2,2,1,1,2,2,3}};
    public static string[] RED = {"Balance something on your nose"
                                ,"Do 2 push ups"
                                ,"Do 2 squats."
                                ,"Do a deep dab"
                                ,"T-Pose"
                                ,"Wear your shoes like gloves until the next challenge"
                                ,"Pretend to propose to your teammate"
                                ,"Pretend to have a divorce settlement with a teammate and argue who gets the dog"
                                ,"Pat your head and rub your stomach and hop on one foot"};
    public static string[] GREEN = {"Tell a dad joke"
                                ,"Tell an embarrassing story"
                                ,"When was the last time you lied?"
                                ,"What's your biggest fear?"
                                ,"What's the strangest thing you've ever eaten?"
                                ,"Do you have a hidden talent?"
                                ,"If you could live in the world of any movie, show, game, or book, which one would it be?"
                                ,"Milk first or cereal first?"
                                ,"Have you ever lied to get out of a bad date?"
                                ,"What's the most you've spent on a night out?"
                                ,"Have you ever returned or re-gifted a present?"
                                ,"What’s a pet peeve of yours?"};
    
    //static Random rand = new Random();
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
