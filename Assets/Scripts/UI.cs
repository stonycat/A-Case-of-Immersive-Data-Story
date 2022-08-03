using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    public InputActionAsset inputActions;
    private Canvas _canv;
    private InputAction _menu;

    //logging
    private int logCounter = 0;
    private Camera mainCamera;

    private void OnEnable()
    {
        mainCamera = Camera.main;
    }

    void Start()
    {
        _canv = GetComponent<Canvas>();
        _menu = inputActions.FindActionMap("XRI LeftHand").FindAction("Menu");
        _menu.Enable();
        _menu.performed += ToggleMenu;
        _canv.enabled = false;

    }

    // Update is called once per frame
    public void ToggleMenu(InputAction.CallbackContext context)  //X????
    {
        Debug.Log("<pf> in togglemenu");
        // start logging here
        if (LoggingManager.Instance)
        {
            LoggingManager.Instance.StartLogging();
            Debug.Log("<pf> startlogging");
        }

        _canv.enabled = !_canv.enabled;

        //logging
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "ToggleMenu";
        string actionDetail = "open";
        if (logCounter % 2 == 0) { actionDetail = "close"; }
        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, actionDetail, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);

        Debug.Log("<pf> log togglemenu");
    }
}
