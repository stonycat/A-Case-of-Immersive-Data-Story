using System.Collections.Generic;
using UnityEngine;

public class LoggingManager : MonoBehaviour
{
    [SerializeField]
    private StudyManager m_studyManager;

    public StudyManager StudyManager { get => m_studyManager; private set => m_studyManager = value; }

    [SerializeField]
    private AcrossClassParameterManager m_acrossClassParameterManager;

    public AcrossClassParameterManager AcrossClassParameterManager { get => m_acrossClassParameterManager; private set => m_acrossClassParameterManager = value; }

    [SerializeField]
    private ManipulationEventLogger m_manipulationEventLogger;

    [SerializeField]
    private CameraEventLogger m_cameraEventLogger;

    //[SerializeField]
    //private bool m_debugMode;

    private static LoggingManager m_instance;
    public static LoggingManager Instance { get { return m_instance; } }

    private List<ManipulationEventDataObject> m_manipulationEventDataPoints = new List<ManipulationEventDataObject>();


    // Here Need a NetworkObject

    private void Awake()
    {
        // 单例模式
        if (m_instance != null && m_instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            m_instance = this;
        }

        m_cameraEventLogger.gameObject.SetActive(false);
    }


    public void StartLogging() {
        m_manipulationEventLogger?.StartListening();
        //m_cameraEventLogger.gameObject.SetActive(true);
    }


    public void StopLogging() {
        m_manipulationEventLogger?.StopListening();
        m_cameraEventLogger.gameObject.SetActive(false);
    }


    public void InvokeManipulationEvent(ManipulationEventArgs a_args)
    {
        if (m_manipulationEventLogger != null)
        {
            m_manipulationEventLogger.InvokeCustomEvent(a_args);
        }
        else
        {
            Debug.Log("<pf> Could not log manipulation event. Manipulation event logger not initialized.");
        }
    }


    public void OnManipulationEventTriggered(ManipulationEventDataObject dataPoint) {
        //m_manipulationEventDataPoints.Add(dataPoint);
        StartCoroutine(NetworkSupporter.Instance.RecordManipulationEvent(dataPoint));
    }

    public void OnCameraEventTriggered(CameraEventDataObject dataPoint) {
        StartCoroutine(NetworkSupporter.Instance.RecordCameraEvent(dataPoint));
    }

    // Start is called before the first frame update
    void Start()
    {
        if (LoggingManager.Instance)
        {
            LoggingManager.Instance.StartLogging();
            Debug.Log("<pf> startlogging");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
