using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PersonAngle : MonoBehaviour
{

    public GameObject person;
    public GameObject rig;
    public GameObject prig;
    public GameObject but;

    public GameObject leftHand;
    public GameObject rightHand;
    //logging
    private int logCounter = 0;
    private Camera mainCamera;

    private void OnEnable()
    {
        mainCamera = Camera.main;
    }

    public void EnterPersonAngle()
    {
        person.SetActive(false);
        rig.SetActive(false);
        prig.SetActive(true);
        but.SetActive(false);

        leftHand.SetActive(false);
        rightHand.SetActive(false);
        //logging
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "StudentPSwitch";
        string actionDetail = "enter";
        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, actionDetail, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);
    }
    public void ExitPersonAngle()
    {
        person.SetActive(true);
        prig.SetActive(false);
        rig.SetActive(true);
        but.SetActive(true);

        leftHand.SetActive(true);
        rightHand.SetActive(true);
        //logging
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "StudentPSwitch";
        string actionDetail = "exit";
        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, actionDetail, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);
    }

}
