using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEditor.XR;
using Unity.XR;
using System;

public class ChangeCamera : MonoBehaviour
{

    public InputActionAsset inputActions;
    private InputAction _camera;
    private bool up;
    public GameObject wall;
    public GameObject tele;

    //public GameObject leftHand;
    //public GameObject rightHand;
    //logging
    private int logCounter = 0;
    private Camera mainCamera;
    private static float x, z;

    private void OnEnable()
    {
        mainCamera = Camera.main;
    }

    // Start is called before the first frame update
    void Start()
    {
        _camera = inputActions.FindActionMap("XRI RightHand").FindAction("Camera");
        _camera.Enable();
        _camera.performed += ToggleCamera;
        up = false;
        wall.SetActive(true);
    }

    // Update is called once per frame
    public void ToggleCamera(InputAction.CallbackContext context)
    {
        if (up)
        {
            
            transform.position = new Vector3(x,0,z);
            //transform.Rotate(new Vector3(330 ,305, 0));
            transform.rotation = new Quaternion(0, 90, 0, 0);
            //rig.GetComponent<>

            //    leftHand.transform.position += new Vector3(0, -5, -14);
              //  rightHand.transform.position += new Vector3(0, -5, -14);
                //leftHand.transform.rotation = new Quaternion(0, 90, 0, 0);
                //rightHand.transform.rotation = new Quaternion(0, 90, 0, 0);


            up = false;
            wall.SetActive(true);
            tele.SetActive(true);
        }
        else
        {
            x = transform.position.x;
            z = transform.position.z;
            transform.position = new Vector3(-8, 6, 16);
            transform.rotation = new Quaternion(40, 145, -40, 0);
            //transform.Rotate(new Vector3(30,55,0));

    //        leftHand.transform.position += new Vector3(0, 5, 14);
      //      rightHand.transform.position += new Vector3(0, 5, 14);
        //    leftHand.transform.rotation = new Quaternion(30, 145, -30, 0);
          //  rightHand.transform.rotation = new Quaternion(30, 145, -30, 0);

            up = true;
            wall.SetActive(false);
            tele.SetActive(false);
        }
        /*
        if(up){
            rig1.SetActive(false);
            rig.SetActive(true);
            up = false;
        }
        else
        {
            rig.SetActive(false);
            rig1.SetActive(true);
            up = true;
        }
        */

        //logging
        UIState UIStat = LoggingManager.Instance.AcrossClassParameterManager.CurrentUIState;
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "SwitchPerspective";
        string actionDetail = "{thirdP__";
        if (logCounter % 2 == 0) { actionDetail = "firstP__"; }
        actionDetail = actionDetail + "windowMode: " + UIStat.windowMode + "__" + "visualizationType: " + UIStat.visualizationType + "__"
            + "heatmapPage: " + UIStat.heatmapPage + "__" + "heatmapLayer: " + UIStat.heatmapLayer;
        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, actionDetail, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);
    }

    private Quaternion Quaternion(int v1, int v2, int v3, int v4)
    {
        throw new NotImplementedException();
    }

}
