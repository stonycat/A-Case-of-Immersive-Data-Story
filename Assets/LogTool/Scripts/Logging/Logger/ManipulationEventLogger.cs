using UnityEngine;
using UnityEngine.Events;

public class ManipulationEventLogger : BaseEventLogger
{
    [SerializeField]
    private LoggingManager m_loggingManager; // This can be omitted and replaced by LoggingManager.Instance

    private readonly UnityEvent<ManipulationEventArgs> m_customEvent = new UnityEvent<ManipulationEventArgs>();

    public override void StartListening()
    {
        m_customEvent.AddListener(OnManipulationEventReceived);
    }

    public override void StopListening()
    {
        m_customEvent.RemoveAllListeners();
    }

    public void InvokeCustomEvent(ManipulationEventArgs a_args) {  
        m_customEvent.Invoke(a_args);
    }

    private void OnManipulationEventReceived(ManipulationEventArgs a_args)
    {
        ManipulationEventDataObject customEventDataObject = new ManipulationEventDataObject(m_loggingManager.StudyManager)
        {
            LogCounter = a_args.LogCounter,
            EventName = a_args.EventName,
            EventStartTime = a_args.StartTime,
            EventEndTime = a_args.EndTime,
            ActionValue = a_args.ActionValue,
            CameraPosition = a_args.CameraPosition,
            CameraRotation = a_args.CameraRotation,
        };
    m_loggingManager.OnManipulationEventTriggered(customEventDataObject);
    }
}



public class ManipulationEventArgs
{

    // Is it ok to omit {get; set;}?
    public string LogCounter { get; set; }

    public string EventName { get; set; }

    public string StartTime { get; set; }

    public string EndTime { get; set; }

    public string ActionValue { get; set; }

    public string CameraPosition { get; set; }

    public string CameraRotation { get; set; }


    public ManipulationEventArgs(

     string a_logCounter,

     string a_eventName,

     string a_startTime,

     string a_endTime,

     string a_actionValue,

     string a_cameraPosition,

     string a_cameraRotation)
    {
        LogCounter = a_logCounter;
        EventName = a_eventName;
        StartTime = a_startTime;
        EndTime = a_endTime;
        ActionValue = a_actionValue;
        CameraPosition = a_cameraPosition;
        CameraRotation = a_cameraRotation;
    }
}