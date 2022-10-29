using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class VC_Manager : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera playerCamera;
    [SerializeField] CinemachineVirtualCamera diceCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Switch Camera
        }
    }
}
