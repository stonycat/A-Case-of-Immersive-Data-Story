using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionDataObect : BaseLoggingDataObject
{

    public string SessionStartTime;
    public string SessionEndTime;

    public SessionDataObect() : base() { }

    public SessionDataObect(StudyManager a_studyManager) :
    base(a_studyManager)
    {
        SessionStartTime = a_studyManager.AppSessionInfo.SessionStartTime;
        SessionEndTime = a_studyManager.AppSessionInfo.SessionEndTime;
    }

}
