using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private Camera _mainCamera;

    public colorChangingScript colorChangingScript;
    public dataLoggerScript dataLoggerScript;

    private void Awake()
    {
        _mainCamera = Camera.main;

    }

    private void Update()
    {
        dataLoggerScript.time += Time.deltaTime; 
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider)
        {
            return;
        }
        else
        {

            //colorChangingScript.score = colorChangingScript.score + 1;
            dataLoggerScript.Finaltime = dataLoggerScript.time;
            dataLoggerScript.time = 0;
            colorChangingScript.changeColor(rayHit.collider.gameObject);

            Debug.Log(rayHit.collider.gameObject.name);
        }

    }
}
