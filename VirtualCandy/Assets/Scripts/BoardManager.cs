using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour
{
    public static int ROWS;
    public static int COLS;
    int[,] BOARD;
    int i;
    int j;
    //static Random rand = new Random();
    // Start is called before the first frame update
    void Start()
    {
        ROWS = 12;
        COLS = 12;
        BOARD = new int[ROWS,COLS];
        


        for ( i = 0; i < ROWS; i++) {
            for( j = 0; j < COLS; j++) {
                BOARD[i,j] = Random.Range(0,3);
            }
        }
        BOARD[0,0] = -1;
        for(i = 0; i < ROWS; i++) {
            for(j = 0; j < COLS; j++) {
                Debug.Log(BOARD[i,j]);
            }
            Debug.Log("\n");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
