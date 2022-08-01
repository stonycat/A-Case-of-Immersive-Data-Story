public class CameraEventDataObject : BaseLoggingDataObject
{
    public override LoggingDataType Type => LoggingDataType.CameraEvent;

    public string LogCounter;

    public string EventStartTime;

    public string EventName;

    public string CameraPosition;

    public string CameraRotation;

    public string IsExceedSpeedThreshold;

    public string IsExceedAngularVThreshold;

    public string CapturedSreenshot;


    public CameraEventDataObject() : base() { }

    public CameraEventDataObject(StudyManager a_studyManager) :
        base(a_studyManager)
    {

    }
}
