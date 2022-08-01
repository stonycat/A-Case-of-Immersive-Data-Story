using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIChangeText : MonoBehaviour
{
    public static int page = 1;
    private int cases;
    public GameObject firstPerson;
    public GameObject tex;
    public GameObject content;

    public Material white;
    public Material blue;
    public GameObject subtex;
    public GameObject mark3;

    public AudioClip cn11, cn12, cn13, cn14, cn15, cnl21, cnl22, cnl31, cnl32, cnl41;
    public AudioClip cnh21, cnh31, cnh41, cnp21, cnp31, cnp41;
    public GameObject aud;
    private AudioSource audioSrc;


    public GameObject buttonR;
    public GameObject buttonF;

    public GameObject fan;

    public GameObject ray1;
    public GameObject ray2;
    public GameObject ray3;

    public GameObject h11, h12, h13, h21, h22, h23, h31, h32, h33;
    public GameObject p2, p3, p4;

    public GameObject showButton;

    public GameObject boxU;
    public GameObject boxD;

    public GameObject title;

    public GameObject ray;
    public GameObject heatmap;
    public GameObject particle;

    public GameObject winclose;
    public GameObject winopen;
    public GameObject withafan;
    public GameObject background;

    public GameObject dropdown;
    public GameObject showLevel;

    private string t1 = "";
    private string t2 = "";
    private string t3 = "";
    private string t4 = "";
    private string t5 = "";
    //close
    private string t_2_1 = "";
    private string t_2_2 = "";
    private string t_2_3 = "";
    //open
    private string t_3_1 = "";
    private string t_3_2 = "";
    private string t_3_3 = "";
    private string t_3_4 = "";
    //fan
    private string t_4_1 = "";
    private string t_4_2 = "";

    private string st1 = "Here’s a typical classroom.This scene is based on a real public school classroom in New York City.";
    private string st2 = "New York City put strict protocols in place for reopening schools. Students must practice social distancing and wear masks, and classrooms must have windows that open.";
    private string st3 = "This classroom seats just nine students, all wearing typical cloth face masks, facing forward and sitting six feet apart. With all of the windows closed, the room would lack sufficient ventilation. ";
    private string st4 = "The students are wearing masks, but their breath still circulates and mixes around the room. About 3 percent of the air each person in this room breathes was exhaled by other people.";
    private string st5 = "Even students who look healthy may be asymptomatic carriers who can transmit the virus.";
    //close
    private string st_2_1 = "These lines trace the student’s warm breath as it rises and begins to disperse contaminated respiratory aerosols throughout the room.";
    private string st_2_2 = "With little fresh air coming into the space, the contaminants continue to circulate throughout the room. Please open the window following the prompt in the room.";
    //open
    private string st_3_1 = "Good ventilation is the most effective and practical way to rid a space of contaminants.The fresh air dilutes the contaminants as they move around the room. ";
    private string st_3_2 = "We managed to desalinate the virus concentration in the air by opening just one window. But that's not up to six air exchanges, and we have to do more. Please open the fan by tapping the button next to the window.";
    //fan
    private string st_4_1 = "The increased fresh air blowing into the room and the filtered air coming from the air cleaner help to further dilute the contaminants as they spread in the space. ";

    private string sh2 = "With the window closed, the contaminants accumulate in high concentrations because they have nowhere to go. Each layer shows a full cross-section of the space once the room has reached a peak level of contamination. ";
    private string sh3 = "With the window open, the concentration remains densest near the infected student, but the contaminants are diluted in the rest of the room. Exposure for the other students is reduced.";
    private string sh4 = "With an air cleaner and a fan, the overall concentration levels are at their lowest. The contaminants are concentrated at the front of the room where the fan is blowing, and diluted everywhere else";

    private string sp2 = "Now the window is closed. We use particles to simulate the levels of contamination in the room. You can feel the concentration of particles around you. You can take a walk around or open the window n the room.";
    private string sp3 = "With the window open, the concentration remains densest near the infected student, but the contaminants are diluted in the rest of the room.";
    private string sp4 = " With an air cleaner and a fan, the overall concentration levels are at their lowest. The contaminants are concentrated at the front of the room where the fan is blowing, and diluted everywhere else. You can feel the difference by walking around or checking the indicator interface.";

    //logging
    private int logCounter = 0;
    private Camera mainCamera;

    private void OnEnable()
    {
        mainCamera = Camera.main;
    }

    private void Start()
    {

        tex.GetComponent<TextMeshProUGUI>().text = t1;
        subtex.GetComponent<TextMeshProUGUI>().text = "1.1";
        ray1.SetActive(false);
        ray2.SetActive(false);
        ray3.SetActive(false);
        audioSrc = aud.GetComponent<AudioSource>();


    }
 /*   public void setPage(int npage)
    {
        page = npage;
    }

    public int getPage()
    {
        return page;
    }*/

    public void playAudio()
    {
        PlaySound(page);
    }

    public void stopAudio()
    {
        audioSrc.Stop();
    }

    public void ChangeTextF()
    {
        showButton.SetActive(true);
        switch (page)
        {

            /*
            case 1:
                tex.GetComponent<TextMeshProUGUI>().text = "second"; page += 1;
                break;
            */

            case 1:
                tex.GetComponent<TextMeshProUGUI>().text = t2; page += 1;
                subtex.GetComponent<TextMeshProUGUI>().text = "1.2";
                buttonR.SetActive(true);
                break;
            case 2:
                tex.GetComponent<TextMeshProUGUI>().text = t3; page += 1;
                subtex.GetComponent<TextMeshProUGUI>().text = "1.3";
                mark3.SetActive(true);
                break;
            case 3:
                tex.GetComponent<TextMeshProUGUI>().text = t4; page += 1;
                subtex.GetComponent<TextMeshProUGUI>().text = "1.4";
                mark3.SetActive(false);
                break;
            case 4:
                {
                    tex.GetComponent<TextMeshProUGUI>().text = t5; page += 1;
                    subtex.GetComponent<TextMeshProUGUI>().text = "1.5";
                    buttonF.SetActive(false);
                    break;
                }
            case 31:
                tex.GetComponent<TextMeshProUGUI>().text = t_3_2; page += 1;
                subtex.GetComponent<TextMeshProUGUI>().text = "3.2";
                buttonR.SetActive(true);
                buttonF.SetActive(false);
                break;

            case 21:
                tex.GetComponent<TextMeshProUGUI>().text = t_2_2; page += 1;
                subtex.GetComponent<TextMeshProUGUI>().text = "2.2";
                buttonR.SetActive(true);
                buttonF.SetActive(false);
                break;
            default:
                break;
        }

        audioSrc.Stop();
        PlaySound(page);
    }
    public void ChangeTextB()
    {
        showButton.SetActive(true);
        switch (page)
        {
            /*
            case 1:
                tex.GetComponent<TextMeshProUGUI>().text = "second"; page -= 1;
                break;
            */
            case 2:
                tex.GetComponent<TextMeshProUGUI>().text = t1; ; page -= 1;
                subtex.GetComponent<TextMeshProUGUI>().text = "1.1";
                buttonR.SetActive(false);
                break;
            case 3:
                tex.GetComponent<TextMeshProUGUI>().text = t2; page -= 1;
                subtex.GetComponent<TextMeshProUGUI>().text = "1.2";
                break;
            case 4:
                tex.GetComponent<TextMeshProUGUI>().text = t3; page -= 1;
                subtex.GetComponent<TextMeshProUGUI>().text = "1.3";
                break;
            case 5:
                tex.GetComponent<TextMeshProUGUI>().text = t4; page -= 1;
                subtex.GetComponent<TextMeshProUGUI>().text = "1.4";
                buttonF.SetActive(true);
                break;

            case 32:
                tex.GetComponent<TextMeshProUGUI>().text = t_3_1; page -= 1;
                subtex.GetComponent<TextMeshProUGUI>().text = "3.1";
                buttonR.SetActive(false);
                buttonF.SetActive(true);
                break;
            case 22:
                tex.GetComponent<TextMeshProUGUI>().text = t_2_1; page -= 1;
                subtex.GetComponent<TextMeshProUGUI>().text = "2.1";
                buttonR.SetActive(false);
                buttonF.SetActive(true);
                break;
            default:
                break;
        }
        audioSrc.Stop();
        PlaySound(page);
    }
    
    //page current
    public void PlaySound(int clip)
    {
        switch (clip)
        {
            case 1:
                audioSrc.PlayOneShot(cn11);
                break;
            case 2:
                audioSrc.PlayOneShot(cn12);
                break;
            case 3:
                audioSrc.PlayOneShot(cn13);
                break;
            case 4:
                audioSrc.PlayOneShot(cn14);
                break;
            case 5:
                audioSrc.PlayOneShot(cn15);
                break;
            case 21:
                audioSrc.PlayOneShot(cnl21);
                break;
            case 22:
                audioSrc.PlayOneShot(cnl22);
                break;
            case 31:
                audioSrc.PlayOneShot(cnl31);
                break;
            case 32:
                audioSrc.PlayOneShot(cnl32);
                break;
            case 41:
                audioSrc.PlayOneShot(cnl41);
                break;
            case 121:
                audioSrc.PlayOneShot(cnh21);
                break;
            case 131:
                audioSrc.PlayOneShot(cnh31);
                break;
            case 141:
                audioSrc.PlayOneShot(cnh41);
                break;
            case 221:
                audioSrc.PlayOneShot(cnp21);
                break;
            case 231:
                audioSrc.PlayOneShot(cnp31);
                break;
            case 241:
                audioSrc.PlayOneShot(cnp41);
                break;

        }
    }
    
    
    public void Heatmap()
    {

        ray.SetActive(false);
        heatmap.SetActive(true);
        particle.SetActive(false);
        dropdown.SetActive(true);
        if (cases == 2)
        {

            background.SetActive(false);
            winclose.SetActive(true);
            winopen.SetActive(false);
            withafan.SetActive(false);

            tex.GetComponent<TextMeshProUGUI>().text = t_2_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "2.1";
            title.GetComponent<TextMeshProUGUI>().text = "closed window";
            boxU.SetActive(true);
            boxD.SetActive(false);
            //buto.SetActive(false);
            page = 121;
            buttonF.SetActive(false);
            buttonR.SetActive(false);
            boxU.SetActive(true);
            boxD.SetActive(false);
            audioSrc.Stop();
            audioSrc.PlayOneShot(cnh31);
            fan.SetActive(false);
            h11.SetActive(true);
            h12.SetActive(true);
            h13.SetActive(true);
            h21.SetActive(false);
            h22.SetActive(false);
            h23.SetActive(false);
            h31.SetActive(false);
            h23.SetActive(false);
            h33.SetActive(false);
        }
        if (cases == 3)
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_3_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "3.1";
            title.GetComponent<TextMeshProUGUI>().text = "opened window";
            page = 131;
            buttonF.SetActive(false);
            buttonR.SetActive(false);
            boxU.SetActive(true);
            boxD.SetActive(false);
            audioSrc.Stop();
            audioSrc.PlayOneShot(cnh21);
            fan.SetActive(false);
            boxU.SetActive(true);
            boxD.SetActive(false);
            h11.SetActive(false);
            h12.SetActive(false);
            h13.SetActive(false);
            h21.SetActive(true);
            h22.SetActive(true);
            h23.SetActive(true);
            h31.SetActive(false);
            h23.SetActive(false);
            h33.SetActive(false);
        }
        if (cases == 4)
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_4_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "4.1";
            title.GetComponent<TextMeshProUGUI>().text = "with a fan";
            boxU.SetActive(false);
            boxD.SetActive(true);
            fan.SetActive(true);
            page = 141;
            buttonF.SetActive(false);
            buttonR.SetActive(false);
            boxU.SetActive(true);
            boxD.SetActive(false);
            audioSrc.Stop();
            audioSrc.PlayOneShot(cnh41);
            h11.SetActive(false);
            h12.SetActive(false);
            h13.SetActive(false);
            h21.SetActive(false);
            h22.SetActive(false);
            h23.SetActive(false);
            h31.SetActive(true);
            h23.SetActive(true);
            h33.SetActive(true);
        }
        //logging
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "MenuClick";
        string actionDetail = "heatmap";
        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, actionDetail, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);

        //update UI State
        LoggingManager.Instance.AcrossClassParameterManager.CurrentUIState.visualizationType = "heatmap";
    }

    public void Particle()
    {

        ray.SetActive(false);
        heatmap.SetActive(false);
        particle.SetActive(true);
        dropdown.SetActive(false);
        if (cases == 2) //UI page conditions
        {

            showLevel.SetActive(true);
            background.SetActive(false);
            winclose.SetActive(true);
            winopen.SetActive(false);
            withafan.SetActive(false);

            tex.GetComponent<TextMeshProUGUI>().text = t_2_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "2.1";
            title.GetComponent<TextMeshProUGUI>().text = "closed window";
            boxU.SetActive(true);
            boxD.SetActive(false);
            //buto.SetActive(false);
            page = 221;
            buttonF.SetActive(false);
            buttonR.SetActive(false);
            fan.SetActive(false);
            boxU.SetActive(true);
            boxD.SetActive(false);
            audioSrc.Stop();
            audioSrc.PlayOneShot(cnp31);
            p3.SetActive(false);
            p4.SetActive(false);
            p2.SetActive(true);
        }
        if (cases == 3)
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_3_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "3.1";
            title.GetComponent<TextMeshProUGUI>().text = "opened window";
            page = 231;
            buttonF.SetActive(false);
            buttonR.SetActive(false);
            boxU.SetActive(true);
            boxD.SetActive(false);
            fan.SetActive(false);
            audioSrc.Stop();
            audioSrc.PlayOneShot(cnp21);
            p3.SetActive(true);
            p2.SetActive(false);
            p4.SetActive(false);
        }
        if (cases == 4)
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_4_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "4.1";
            title.GetComponent<TextMeshProUGUI>().text = "with a fan";
            boxU.SetActive(false);
            boxD.SetActive(true);
            fan.SetActive(true);
            page = 241;
            buttonF.SetActive(false);
            buttonR.SetActive(false);
            audioSrc.Stop();
            audioSrc.PlayOneShot(cnp41);
            p4.SetActive(true);
            p3.SetActive(false);
            p2.SetActive(false);
        }

        //logging
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "MenuClick";
        string actionDetail = "particle";
        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, actionDetail, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);

        //update UI State
        LoggingManager.Instance.AcrossClassParameterManager.CurrentUIState.visualizationType = "particle";
    }
    public void Ray()
    {

        ray.SetActive(true);
        heatmap.SetActive(false);
        particle.SetActive(false);
        dropdown.SetActive(false);
        if (cases == 2)
        {

            background.SetActive(false);
            winclose.SetActive(true);
            winopen.SetActive(false);
            withafan.SetActive(false);

            tex.GetComponent<TextMeshProUGUI>().text = t_2_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "2.1";
            title.GetComponent<TextMeshProUGUI>().text = "closed window";
            boxU.SetActive(true);
            boxD.SetActive(false);
            //buto.SetActive(false);
            page = 21;
            buttonF.SetActive(true);
            buttonR.SetActive(false);
            boxU.SetActive(true);
            boxD.SetActive(false);
            fan.SetActive(false);
            audioSrc.Stop();
            audioSrc.PlayOneShot(cnl31);
            ray1.SetActive(true);
            ray2.SetActive(false);
            ray3.SetActive(false);
        }
        if (cases == 3)
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_3_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "3.1";
            title.GetComponent<TextMeshProUGUI>().text = "opened window";
            page = 31;
            buttonF.SetActive(true);
            buttonR.SetActive(false);
            boxU.SetActive(true);
            boxD.SetActive(false);
            audioSrc.Stop();
            audioSrc.PlayOneShot(cnl21);
            boxU.SetActive(true);
            fan.SetActive(false);
            boxD.SetActive(false);
            ray1.SetActive(false);
            ray2.SetActive(true);
            ray3.SetActive(false);
        }
        if (cases == 4)
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_4_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "4.1";
            title.GetComponent<TextMeshProUGUI>().text = "with a fan";
            boxU.SetActive(false);
            boxD.SetActive(true);
            fan.SetActive(true);
            page = 41;
            buttonF.SetActive(false);
            buttonR.SetActive(false);
            audioSrc.Stop();
            audioSrc.PlayOneShot(cnl41);
            ray1.SetActive(false);
            ray2.SetActive(false);
            ray3.SetActive(true);
        }

        //logging
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "MenuClick";
        string actionDetail = " trajectory";
        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, actionDetail, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);

        //update UI State
        LoggingManager.Instance.AcrossClassParameterManager.CurrentUIState.visualizationType = "trajectory";

    }

    public void WindowOpened()
    {
        showButton.SetActive(true);
        fan.SetActive(false);
        mark3.SetActive(false);

        background.SetActive(false);
        winclose.SetActive(false);
        winopen.SetActive(true);
        withafan.SetActive(false);
        showLevel.SetActive(true);
        if (page < 100)  //ray
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_3_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "3.1";
            title.GetComponent<TextMeshProUGUI>().text = "opened window";
            page = 31;
            buttonF.SetActive(true);
            buttonR.SetActive(false);
            boxU.SetActive(false);
            boxD.SetActive(true);
            audioSrc.Stop();
            PlaySound(31);
            //buto.SetActive(false);
            ray1.SetActive(false);
            ray2.SetActive(true);
            ray3.SetActive(false);

        }
        else if (page > 200)
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_3_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "3.1";
            title.GetComponent<TextMeshProUGUI>().text = "opened window";
            page = 231;
            buttonF.SetActive(false);
            buttonR.SetActive(false);
            boxU.SetActive(false);
            boxD.SetActive(true);
            audioSrc.Stop();
            PlaySound(231);
            p3.SetActive(true);
            p2.SetActive(false);
            p4.SetActive(false);
        }
        else
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_3_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "3.1";
            title.GetComponent<TextMeshProUGUI>().text = "opened window";
            page = 131;
            buttonF.SetActive(false);
            buttonR.SetActive(false);
            boxU.SetActive(false);
            boxD.SetActive(true);
            audioSrc.Stop();
            PlaySound(131);
            h11.SetActive(false);
            h12.SetActive(false);
            h13.SetActive(false);
            h21.SetActive(true);
            h22.SetActive(true);
            h23.SetActive(true);
            h31.SetActive(false);
            h32.SetActive(false);
            h33.SetActive(false);
        }

        //logging
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "MenuClick";
        string actionDetail = "windowOpen";
        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, actionDetail, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);

        //update UI State
        LoggingManager.Instance.AcrossClassParameterManager.CurrentUIState.windowMode = "windowOpen";

    }
    public void WindowClosed()
    {
        showButton.SetActive(true);
        fan.SetActive(false);
        mark3.SetActive(false);
        showLevel.SetActive(true);

        background.SetActive(false);
        winclose.SetActive(true);
        winopen.SetActive(false);
        withafan.SetActive(false);

        if (page < 100)
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_2_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "2.1";
            title.GetComponent<TextMeshProUGUI>().text = "closed window";
            boxU.SetActive(true);
            boxD.SetActive(false);
            //buto.SetActive(false);
            page = 21;
            buttonF.SetActive(true);
            buttonR.SetActive(false);
            audioSrc.Stop();
            PlaySound(21);
            ray1.SetActive(true);
            ray2.SetActive(false);
            ray3.SetActive(false);
            fan.SetActive(false);
        }
        else if (page > 200)
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_2_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "2.1";
            title.GetComponent<TextMeshProUGUI>().text = "closed window";
            boxU.SetActive(true);
            boxD.SetActive(false);
            //buto.SetActive(false);
            page = 221;
            buttonF.SetActive(true);
            buttonR.SetActive(false);
            audioSrc.Stop();
            PlaySound(221);
            p3.SetActive(false);
            p4.SetActive(false);
            p2.SetActive(true);
        }
        else
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_2_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "2.1";
            title.GetComponent<TextMeshProUGUI>().text = "closed window";
            boxU.SetActive(true);
            boxD.SetActive(false);
            //buto.SetActive(false);
            page = 121;
            buttonF.SetActive(true);
            buttonR.SetActive(false);
            audioSrc.Stop();
            PlaySound(121);
            h11.SetActive(true);
            h12.SetActive(true);
            h13.SetActive(true);
            h21.SetActive(false);
            h22.SetActive(false);
            h23.SetActive(false);
            h31.SetActive(false);
            h32.SetActive(false);
            h33.SetActive(false);
        }

        //logging
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "MenuClick";
        string actionDetail = "windowClosed";
        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, actionDetail, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);

        //update UI State
        LoggingManager.Instance.AcrossClassParameterManager.CurrentUIState.windowMode = "windowClosed";
    }
    public void withAFan()
    {
        showButton.SetActive(true);
        mark3.SetActive(false);

        background.SetActive(false);
        winclose.SetActive(false);
        winopen.SetActive(false);
        withafan.SetActive(true);
        showLevel.SetActive(true);

        if (page < 100)
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_4_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "4.1";
            title.GetComponent<TextMeshProUGUI>().text = "with a fan";
            boxU.SetActive(false);
            boxD.SetActive(true);
            fan.SetActive(true);
            page = 41;
            buttonF.SetActive(true);
            buttonR.SetActive(false);
            audioSrc.Stop();
            PlaySound(41);
            ray1.SetActive(false);
            ray2.SetActive(false);
            ray3.SetActive(true);
        }
        else if (page > 200)
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_4_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "4.1";
            title.GetComponent<TextMeshProUGUI>().text = "with a fan";
            boxU.SetActive(false);
            boxD.SetActive(true);
            fan.SetActive(true);
            page = 241;
            buttonF.SetActive(true);
            buttonR.SetActive(false);
            audioSrc.Stop();
            PlaySound(241);
            p4.SetActive(true);
            p3.SetActive(false);
            p2.SetActive(false);
        }
        else
        {
            tex.GetComponent<TextMeshProUGUI>().text = t_4_1;
            subtex.GetComponent<TextMeshProUGUI>().text = "4.1";
            title.GetComponent<TextMeshProUGUI>().text = "with a fan";
            boxU.SetActive(false);
            boxD.SetActive(true);
            fan.SetActive(true);
            page = 141;
            buttonF.SetActive(true);
            buttonR.SetActive(false);
            audioSrc.Stop();
            PlaySound(141);
            h11.SetActive(false);
            h12.SetActive(false);
            h13.SetActive(false);
            h21.SetActive(false);
            h22.SetActive(false);
            h23.SetActive(false);
            h31.SetActive(true);
            h32.SetActive(true);
            h33.SetActive(true);
        }

        //logging
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "MenuClick";
        string actionDetail = "fanOpen";
        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, actionDetail, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);

        //update UI State
        LoggingManager.Instance.AcrossClassParameterManager.CurrentUIState.windowMode = "fanOpen";

    }
    public void backgroundButton()
    {

        background.SetActive(true);
        winclose.SetActive(false);
        winopen.SetActive(false);
        withafan.SetActive(false);
        showLevel.SetActive(false);

        dropdown.SetActive(false);

        buttonF.SetActive(true);
        buttonR.SetActive(false);
        tex.GetComponent<TextMeshProUGUI>().text = t1;
        subtex.GetComponent<TextMeshProUGUI>().text = "1.1";
        title.GetComponent<TextMeshProUGUI>().text = "background";
        ray1.SetActive(false);
        ray2.SetActive(false);
        ray3.SetActive(false);
        particle.SetActive(false);
        heatmap.SetActive(false);
        fan.SetActive(false);
        page = 1;
        boxU.SetActive(true);
        boxD.SetActive(false);
        audioSrc.Stop();
        PlaySound(1);
        showButton.SetActive(true);

        //logging
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "MenuClick";
        string actionDetail = "background";
        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, actionDetail, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);

        //update UI State
        LoggingManager.Instance.AcrossClassParameterManager.CurrentUIState.windowMode = "background";
    }
    public void ShowText()
    {
        showButton.SetActive(false);
        switch (page)
        {
            case 1:
                content.GetComponent<TextMeshProUGUI>().text = st1;
                break;
            case 2:
                content.GetComponent<TextMeshProUGUI>().text = st2;
                break;
            case 3:
                content.GetComponent<TextMeshProUGUI>().text = st3;
                break;
            case 4:
                content.GetComponent<TextMeshProUGUI>().text = st4;
                break;
            case 5:
                content.GetComponent<TextMeshProUGUI>().text = st5;
                break;
            case 21:
                content.GetComponent<TextMeshProUGUI>().text = st_2_1;
                break;
            case 22:
                content.GetComponent<TextMeshProUGUI>().text = st_2_2;
                break;
            case 31:
                content.GetComponent<TextMeshProUGUI>().text = st_3_1;
                break;
            case 32:
                content.GetComponent<TextMeshProUGUI>().text = st_3_2;
                break;
            case 41:
                content.GetComponent<TextMeshProUGUI>().text = st_4_1;
                break;
            case 121:
                content.GetComponent<TextMeshProUGUI>().text = sh2;
                break;
            case 131:
                content.GetComponent<TextMeshProUGUI>().text = sh3;
                break;
            case 141:
                content.GetComponent<TextMeshProUGUI>().text = sh4;
                break;
            case 221:
                content.GetComponent<TextMeshProUGUI>().text = sp2;
                break;
            case 231:
                content.GetComponent<TextMeshProUGUI>().text = sp3;
                break;
            case 241:
                content.GetComponent<TextMeshProUGUI>().text = sp4;
                break;
            default:
                break;
        }

        //logging
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "MenuClick";
        string actionDetail = "showText";
        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, actionDetail, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);
    }
    public void DropDownData(int val)
    {
        if (page == 31 || page == 32 || page == 33 || page == 34 || page == 131 || page == 132 || page == 133 || page == 134 || page == 231 || page == 232 || page == 233 || page == 234)
        {
            cases = 3;
        }
        else if (page == 41 || page == 42 || page == 141 || page == 142 || page == 241 || page == 242)
        {
            cases = 4;
        }
        else
        {
            cases = 2;
        }

        showLevel.SetActive(true);
        if (val == 0)
        {
            Ray();
        }
        if (val == 1)
        {
            Particle();
        }
        if (val == 2)
        {
            Heatmap();
        }
    }
    public void DropDownHeatmap(int val)
    {
        if (page == 121)
        {
            if (val == 0)
            {
                h11.SetActive(true);
                h12.SetActive(true);
                h13.SetActive(true);
            }
            if (val == 1)
            {
                h11.SetActive(true);
                h12.SetActive(false);
                h13.SetActive(false);

            }
            if (val == 2)
            {
                h11.SetActive(false);
                h12.SetActive(true);
                h13.SetActive(false);
            }
            if (val == 3)
            {
                h11.SetActive(false);
                h12.SetActive(false);
                h13.SetActive(true);
            }

        }
        if(page == 131)
        {
            if (val == 0)
            {
                h21.SetActive(true);
                h22.SetActive(true);
                h23.SetActive(true);
            }
            if (val == 1)
            {
                h21.SetActive(true);
                h22.SetActive(false);
                h23.SetActive(false);

            }
            if (val == 2)
            {
                h21.SetActive(false);
                h22.SetActive(true);
                h23.SetActive(false);
            }
            if (val == 3)
            {
                h21.SetActive(false);
                h22.SetActive(false);
                h23.SetActive(true);
            }

        }
        if(page == 141)
        {
            if (val == 0)
            {
                h31.SetActive(true);
                h32.SetActive(true);
                h33.SetActive(true);

            }
            if (val == 1)
            {
                h31.SetActive(true);
                h32.SetActive(false);
                h33.SetActive(false);

            }
            if (val == 2)
            {
                h31.SetActive(false);
                h32.SetActive(true);
                h33.SetActive(false);
            }
            if (val == 3)
            {
                h31.SetActive(false);
                h32.SetActive(false);
                h33.SetActive(true);
            }

        }
        //logging
        logCounter = logCounter + 1;
        string startTimestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
        string endTimestamp = "";
        string eventName = "MenuClick";
        string actionDetail = "dropDownHeatmap Page "+page.ToString()+" Val "+val.ToString();
        string cameraPostn = (mainCamera.transform.position - CameraEventLogger.startCameraPostn).ToString();
        string cameraRottn = mainCamera.transform.rotation.ToString();
        ManipulationEventArgs args = new ManipulationEventArgs(logCounter.ToString(), eventName, startTimestamp, endTimestamp, actionDetail, cameraPostn, cameraRottn);
        LoggingManager.Instance.InvokeManipulationEvent(args);

        //update UI State
        LoggingManager.Instance.AcrossClassParameterManager.CurrentUIState.heatmapPage = page.ToString();
        LoggingManager.Instance.AcrossClassParameterManager.CurrentUIState.heatmapLayer = val.ToString();
    }

}
