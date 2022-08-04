public class ManipulationEventDataObject : BaseLoggingDataObject
{
    public override LoggingDataType Type => LoggingDataType.ManipulationEvent;

    public string EventStartTime;

    public string EventEndTime;

    public string LogCounter;

    public string EventName;

    public string ActionValue;

    public string CameraPosition;

    public string CameraRotation;

    public ManipulationEventDataObject() : base() { }

    public ManipulationEventDataObject(StudyManager a_studyManager) :
        base(a_studyManager)
    {

    }
}
