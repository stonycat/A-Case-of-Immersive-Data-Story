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
       

        //m_arCamera = GameObject.FindGameObjectWithTag(cameraTag).GetComponent<Camera>();

        //if (!m_arCamera)
        //{
        //    Debug.LogError("The camera object is not found.");
        //}

        //logCounter = 0;


        //Vector3 nowCameraPostn = m_arCamera.transform.position;
        //Quaternion nowCameraRottn = m_arCamera.transform.rotation;

        //Debug.Log("Camera Position: " + logCounter + nowCameraPostn.ToString()); //shall be (0,0,0)
        //Debug.Log("Camera Rotation: " + logCounter + nowCameraRottn.ToString());

        //logCounter += 1;
        //m_prevCameraPostn = nowCameraPostn;
        //m_prevCameraRottn = nowCameraRottn;

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

        //Check if rotation > 40 degree/s
        float angularVelocity = Quaternion.Angle(nowCameraRottn, m_prevCameraRottn) / deltaTimeTemp;

        
        if (speed < 0.5 && angularVelocity > 40)
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
        if ((logCounter == 1) || (logCounter % logMod == 0))
        {
            var texture = ScreenCapture.CaptureScreenshotAsTexture();
            texture_string = Convert.ToBase64String(texture.EncodeToJPG(20));
            UnityEngine.Object.Destroy(texture);
        }

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


//public class CameraEventArgs
//{
//    public string EventStartTime { get; set; }

//    public string EventName { get; set; }

//    public string CameraPosition { get; set; }

//    public string CameraRotation { get; set; }

//    public string IsExceedSpeedThreshold { get; set; }

//    public string IsExceedAngularVThreshold { get; set; }

//    public string CapturedSreenshot { get; set; }

//    public CameraEventArgs(string a_startTime,
//        string a_eventName,
//        string a_cameraPosition,
//        string a_cameraRotation,
//        string a_isExceedSpeedThreshold,
//        string a_isExceedAngularVThreshold,
//        string a_capturedScreenshot)
//    {
//        EventStartTime = a_startTime;
//        EventName = a_eventName;
//        CameraPosition = a_cameraPosition;
//        CameraRotation = a_cameraRotation;
//        IsExceedSpeedThreshold = a_isExceedSpeedThreshold;
//        IsExceedAngularVThreshold = a_isExceedAngularVThreshold;
//        CapturedSreenshot = a_capturedScreenshot;
//    }
//}