using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _roomCam;
    private int _mainCamPriority = 11, _lowCamPriority = 9;

    void Start()
    {
       
    }

    private void Update()
    {
        KeyboardControlls();
    }

    void KeyboardControlls()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null)
            return;
        if (keyboard.rKey.wasPressedThisFrame)
        {
            SetCameraPriority();
        }
    }

    void SetCameraPriority()
    {
        if (_roomCam.Priority != _mainCamPriority)
        {
            _roomCam.Priority = _mainCamPriority;
        }
        else
        {
            _roomCam.Priority = _lowCamPriority;
        }
    }
}
