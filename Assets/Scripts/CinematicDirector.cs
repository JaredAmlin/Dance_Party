using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CinematicDirector : MonoBehaviour
{
    [SerializeField] private GameObject _cinematicDirector;

    private float _cinematicWaitTime = 5f;
    private float _timeToWait = 0f;

    private void Start()
    {
        _timeToWait = Time.time + _cinematicWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        var keyboard = Keyboard.current;
        var mouse = Mouse.current;
        if (keyboard == null)
            return;
        if (mouse == null)
            return;

        if (Time.time > _timeToWait)
        {
            Debug.Log("It's time to start the cinematic cut!");
            //enable director
        }

        if (keyboard.anyKey.isPressed)
        {
            Debug.Log("Keyboard stops the cinematic cut!");
            _timeToWait = Time.time + _cinematicWaitTime;
            //disable director
        }

        //Vector2 mousePosition = mouse.position.ReadValue();
        //if (mousePosition.sqrMagnitude > 0.01f)
        //{
        //    Debug.Log("Mouse stops the cinematic cut!");
        //    _timeToWait = Time.time + _cinematicWaitTime;
        //}

        else if (keyboard.pKey.wasPressedThisFrame)
        {
            _cinematicDirector.SetActive(true);
        }

        if (keyboard.oKey.wasPressedThisFrame)
        {
            _cinematicDirector.SetActive(false);
        }
    }
}
