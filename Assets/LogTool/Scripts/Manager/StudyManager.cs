using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Networking;
using UnityEditor;

public class StudyManager : MonoBehaviour
{
    [SerializeField]
    private AppInformation m_appInfo;

    public AppInformation AppInfo { get  => m_appInfo; private set => m_appInfo = value ; }

    public AppSessionInformation AppSessionInfo { get; private set; }

    public AppUserInformation AppUserInfo { get; private set; }

    public bool UserIdReady { get; private set; }

    public bool SessionIdReady { get; private set; }

    private static StudyManager m_instance;
    public static StudyManager Instance { get { return m_instance; } }

    //[SerializeField]
    //private NetworkSupporter m_networkSupporter;

    const string charRange = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const int idLength = 32;

    private void Awake()
    {
        if (m_instance != null && m_instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            m_instance = this;
        }

        SessionIdReady = false;
        UserIdReady = false;

        // initialize AppSessionInfo
        if (PlayerPrefs.HasKey("lastSessionId"))
        {
            string lastId = PlayerPrefs.GetString("lastSessionId");
            int id = Int32.Parse(lastId) + 1;
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            AppSessionInfo = new AppSessionInformation() { SessionId = id.ToString(), SessionStartTime = timestamp };
            PlayerPrefs.SetString("lastSessionId", id.ToString());
            SessionIdReady = true;
        }
        else
        {
            int id = 1;
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
            AppSessionInfo = new AppSessionInformation() { SessionId = id.ToString(), SessionStartTime = timestamp };
            PlayerPrefs.SetString("lastSessionId", id.ToString());
            SessionIdReady = true;
        }

        // initialize AppUserInfo
        if (PlayerPrefs.HasKey("userId"))
        {
            string id = PlayerPrefs.GetString("userId");
            AppUserInfo = new AppUserInformation() { UserId = id };
            UserIdReady = true;
        }
        else
        {
            //StartCoroutine(RequestUserIdForNewUsers());
            string id = string.Empty;
            for (int i = 0; i < idLength; i++) {
                id += charRange[UnityEngine.Random.Range(0, charRange.Length)];
            }
            AppUserInfo = new AppUserInformation() { UserId = id };
            UserIdReady = true;
            PlayerPrefs.SetString("userId", id);
        }
    }

    private void OnDestroy()
    {

        string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        AppSessionInfo.SessionEndTime = timestamp;
    }


}
