using System;

[Serializable]
public class BaseLoggingDataObject
{
    public virtual LoggingDataType Type { get; }

    //public Guid DataPointGuid;

    public string AppName;

    public string AppVersionId;

    public string SessionId;

    public string UserId;

    public BaseLoggingDataObject()
    {
    }

    public BaseLoggingDataObject(StudyManager a_studyManager)
    {
        AppName = a_studyManager.AppInfo.AppName;
        AppVersionId = a_studyManager.AppInfo.VersionId;
        SessionId = a_studyManager.AppSessionInfo.SessionId;
        UserId = a_studyManager.AppUserInfo.UserId;
        //DataPointGuid = Guid.NewGuid();
    }
}