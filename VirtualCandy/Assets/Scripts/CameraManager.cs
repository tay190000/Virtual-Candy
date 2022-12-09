using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera playerCam;
    [SerializeField] CinemachineVirtualCamera diceCam;

    private void OnEnable()
    {
        CameraSwitcher.Register(playerCam);
        CameraSwitcher.Register(diceCam);

        CameraSwitcher.SwitchCamera(playerCam);
    }

    private void OnDisable()
    {
        CameraSwitcher.Unregister(playerCam);
        CameraSwitcher.Unregister(diceCam);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (CameraSwitcher.IsActiveCamera(playerCam))
            {
                CameraSwitcher.SwitchCamera(diceCam);
            }

            else if (CameraSwitcher.IsActiveCamera(diceCam))
            {
                CameraSwitcher.SwitchCamera(playerCam);
            }
        }
    }
}
