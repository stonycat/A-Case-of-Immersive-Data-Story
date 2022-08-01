using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CameraEventLogger : MonoBehaviour
{

    public static string cameraTag = "MainCamera";

    public static Vector3 startCameraPostn;

    public static Quaternion startCameraRottn;

    [SerializeField]
    private LoggingManager m_loggingManager;

    private Camera m_arCamera;
    
    private int logCounter;
    private int logMod = 20;
    private int updateCounter = 0;
    private int updateMod = 10;
    private float deltaTimeTemp = 0;

    private Vector3 m_prevCameraPostn;

    private Quaternion m_prevCameraRottn;



    private void OnEnable()
    {
        m_arCamera = Camera.main;
        logCounter = 0;
        if (startCameraPostn != null)
        {
            m_prevCameraPostn = startCameraPostn;
        }
        else
        {
            startCameraPostn = m_arCamera.transform.position;
            m_prevCameraPostn = startCameraPostn;
        }

        if (startCameraRottn != null)
        {
            m_prevCameraRottn = startCameraRottn;
        }
        else
        {
            startCameraRottn = m_arCamera.transform.rotation;
            m_prevCameraRottn = startCameraRottn;
        }
    }
    // Start is called before the first frame update

    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        updateCounter += 1;
        deltaTimeTemp += Time.deltaTime;
        if (updateCounter % updateMod != 0)
        {
            return;
        }

        Vector3 nowCameraPostn = m_arCamera.transform.position;
        Quaternion nowCameraRottn = m_arCamera.transform.rotation;

        string isBigSpeed = "0";
        string isBigAngularV = "0";

        //Debug.Log("Camera Position: " + logCounter + nowCameraPostn.ToString());
        //Debug.Log("Camera Rotation: " + logCounter + nowCameraRottn.ToString());

        //Check if speed > 0.5
        float speed = ((nowCameraPostn - m_prevCameraPostn) / deltaTimeTemp).magnitude;

        if(speed > 0.5)
        {
            isBigSpeed = "1";
        }

        //Check if rotation > 20 degree/s
        float angularVelocity = Quaternion.Angle(nowCameraRottn, m_prevCameraRottn) / deltaTimeTemp;

        
        if (speed < 0.5 && angularVelocity > 20)
        {
            isBigSpeed = "0";
            isBigAngularV = "1";
        }

        logCounter += 1;
        deltaTimeTemp = 0;
        m_prevCameraPostn = nowCameraPostn;
        m_prevCameraRottn = nowCameraRottn;


        //Debug.Log("<pf> speed and velocity" + speed.ToString() + " " + angularVelocity.ToString());


        // Logging
        string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string eventName = "camera";
        string cameraPosition = (nowCameraPostn - startCameraPostn).ToString();
        //string cameraRotation = Quaternion.Angle(nowCameraRottn, startCameraRottn).ToString();
        string cameraRotation = nowCameraRottn.ToString();
        string isExceedSpeedThreshold = isBigSpeed;
        string isExceedAngularVThreshold = isBigAngularV;
        string texture_string = "";

        CameraEventDataObject cameraDataObj = new CameraEventDataObject(m_loggingManager.StudyManager)
        {
            LogCounter = logCounter.ToString(),
            EventStartTime = timestamp,
            EventName = eventName,
            CameraPosition = cameraPosition,
            CameraRotation = cameraRotation,
            IsExceedSpeedThreshold = isExceedSpeedThreshold,
            IsExceedAngularVThreshold = isExceedAngularVThreshold,
            CapturedSreenshot = texture_string
        };
        m_loggingManager.OnCameraEventTriggered(cameraDataObj);
    }
}