using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AppInformation
{
    public string AppName;

    public string VersionId;

    public AppInformation(string a_appName, string a_versionId) {
        AppName = a_appName;
        VersionId = a_versionId; 
    }
}


