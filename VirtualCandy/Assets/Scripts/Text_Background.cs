using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_Background : MonoBehaviour
{
    public static bool moveUP = false;
    public static bool moveDOWN = false;
    private int Frame = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(moveDOWN) {
            if(Frame < 18) {
                transform.position = transform.position + new Vector3(0, -1.0f, 0);
            }
            else if(Frame < 30) {
                transform.position = transform.position + new Vector3(0, -0.166f, 0);
            }
            Frame++;
        }
        else if(moveUP) {
            if(Frame < 12) {
                transform.position = transform.position + new Vector3(0, 0.166f, 0);
            }
            else if(Frame < 30) {
                transform.position = transform.position + new Vector3(0, 1.0f, 0);
            }
            Frame++;
        }
        if(Frame == 30) {
            moveUP = false;
            moveDOWN = false;
            Frame = 0;
        }

    }
}
