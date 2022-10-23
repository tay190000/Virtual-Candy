using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    int Framecount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Framecount < 60) {
            transform.position = transform.position + new Vector3(0, 0.005f, 0);
        }
        else if(Framecount < 180) {
            transform.position = transform.position + new Vector3(0,  0.0016f, 0);
        }
        else if(Framecount < 240) {
            transform.position = transform.position + new Vector3(0,  -0.005f, 0);
        }
        else if(Framecount < 360){
            transform.position = transform.position + new Vector3(0,  -0.0016f, 0);
        }
        else {
            Framecount = -1;
        }
        Framecount++;
    }
}
