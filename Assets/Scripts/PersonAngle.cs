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

        //Debug.Log("personNo." + person.name);
        leftHand.SetActive(false);
        rightHand.SetActive(false);
        //logging
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "StudentPSwitch";
        string actionDetail = "enter_";
        //add aniNum
        string personNumber = actionDetail + person.name;

        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, personNumber, cameraPostn, cameraRottn);
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
        string actionDetail = "exit_";
        //add aniNum
        string personNumber = actionDetail + person.name;

        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, personNumber, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);
    }

}
