using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour
{
    public static int[,] BOARD = {{0,2,1,1,2},{1,1,2,2,1},{2,2,1,2,2},{1,1,2,1,1},{2,2,1,2,3}};
    public static string[] RED = {"test","","","","","","","","","","",""};
    public static string[] GREEN = {"test","","","","","","","","","","",""};
    
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
