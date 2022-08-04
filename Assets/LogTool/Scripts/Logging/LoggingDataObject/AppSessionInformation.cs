using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AppSessionInformation
{
    public string SessionId;

    public string SessionStartTime;
    
    public string SessionEndTime;


    //public AppSessionInformation(string id, string startTime)
    //{
    //    SessionId = id;
    //    StartTimeString = startTime;
    //}


    //public string GetName()
    //{
    //    return GetNamePrefix() + sessionId;
    //}

    //public static string GetNamePrefix()
    //{
    //    return "App_Session_";
    //}

}
