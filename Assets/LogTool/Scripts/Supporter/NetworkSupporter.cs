using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;

public class NetworkSupporter : MonoBehaviour
{
    //[SerializeField]
    private string m_serverBaseUrl = "http://10.89.231.113:1515/";
    //private string m_serverBaseUrl = "http://alex2021ubicomp.s14.hkustvis.org/";

    public string ServerBaseUrl { get => m_serverBaseUrl; private set => m_serverBaseUrl = value; }

    private static NetworkSupporter m_instance;
    public static NetworkSupporter Instance { get { return m_instance; } }

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

        // Here should check whether the network is successful or not. If no, should have some instruction.
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator RecordManipulationEvent(ManipulationEventDataObject dataObject)
    {
        string url = string.Format("{0}/recordManipulationEvent", m_serverBaseUrl);

        WWWForm form = new WWWForm();
        form.AddField("AppName", dataObject.AppName);
        form.AddField("AppVersionId", dataObject.AppVersionId);
        form.AddField("UserId", dataObject.UserId);
        form.AddField("SessionId", dataObject.SessionId);

        form.AddField("LogCounter", dataObject.LogCounter);
        form.AddField("EventName", dataObject.EventName);
        form.AddField("EventStartTime", dataObject.EventStartTime);
        form.AddField("EventEndTime", dataObject.EventEndTime);
        form.AddField("ActionValue", dataObject.ActionValue);
        form.AddField("CameraPosition", dataObject.CameraPosition);
        form.AddField("CameraRotation", dataObject.CameraRotation);

        using (UnityWebRequest request = UnityWebRequest.Post(url, form))
        {
            Debug.Log("<pf> upload manipulation event");

            yield return request.SendWebRequest();

            if ((request.result == UnityWebRequest.Result.ConnectionError) || (request.result == UnityWebRequest.Result.ProtocolError))
            {
                HandleNetworkConnectionIssue(request.error);
            }
            else
            {
                HandleNetworkUploadSuccess();
            }
        }
    }

    public IEnumerator RecordCameraEvent(CameraEventDataObject dataObject)
    {
        Debug.Log("<pf> upload camera event");

        string url = string.Format("{0}/recordCameraEvent", m_serverBaseUrl);

        WWWForm form = new WWWForm();
        form.AddField("AppName", dataObject.AppName);
        form.AddField("AppVersionId", dataObject.AppVersionId);
        form.AddField("UserId", dataObject.UserId);
        form.AddField("SessionId", dataObject.SessionId);

        form.AddField("LogCounter", dataObject.LogCounter);
        form.AddField("EventStartTime", dataObject.EventStartTime);
        form.AddField("EventName", dataObject.EventName);
        form.AddField("CameraPosition", dataObject.CameraPosition);
        form.AddField("CameraRotation", dataObject.CameraRotation);
        form.AddField("IsExceedSpeedThreshold", dataObject.IsExceedSpeedThreshold);
        form.AddField("IsExceedAngularVThreshold", dataObject.IsExceedAngularVThreshold);
        form.AddField("CapturedScreenshot", dataObject.CapturedSreenshot);

        using (UnityWebRequest request = UnityWebRequest.Post(url, form))
        {

            yield return request.SendWebRequest();

            if ((request.result == UnityWebRequest.Result.ConnectionError) || (request.result == UnityWebRequest.Result.ProtocolError))
            {
                HandleNetworkConnectionIssue(request.error);
            }
            else
            {
                HandleNetworkUploadSuccess();
            }
        }
    }

    public IEnumerator RecordSessionInformation(SessionDataObect dataObject) {
        string url = string.Format("{0}/recordSessionInformation", m_serverBaseUrl); 
        WWWForm form = new WWWForm();
        form.AddField("AppName", dataObject.AppName);
        form.AddField("AppVersionId", dataObject.AppVersionId);
        form.AddField("UserId", dataObject.UserId);
        form.AddField("SessionId", dataObject.SessionId);
        form.AddField("SessionStartTime", dataObject.SessionStartTime);
        form.AddField("SessionEndTime", dataObject.SessionEndTime);

        using (UnityWebRequest request = UnityWebRequest.Post(url, form))
        {

            yield return request.SendWebRequest();

            if ((request.result == UnityWebRequest.Result.ConnectionError) || (request.result == UnityWebRequest.Result.ProtocolError))
            {
                HandleNetworkConnectionIssue(request.error);
            }
            else
            {
                HandleNetworkUploadSuccess();
            }
        }
    }

    private void HandleNetworkConnectionIssue(string message)
    {
        GameObject tmpObj  = GameObject.Find("DebugInfoForUser");
        TMP_Text infoForUser = tmpObj.GetComponent<TMPro.TextMeshProUGUI>();
        infoForUser.SetText("Data cannot be logged to database. Please check your network connection.");
        infoForUser.ForceMeshUpdate(true);
    }

    private void HandleNetworkUploadSuccess()
    {
        //GameObject tmpObj = GameObject.Find("DebugInfoForUser");
        //TMP_Text infoForUser = tmpObj.GetComponent<TMPro.TextMeshProUGUI>();
        //infoForUser.SetText("");
        //infoForUser.ForceMeshUpdate(true);
        Debug.Log("<pf> Error in uploading the logs to the server!");
    }

}
