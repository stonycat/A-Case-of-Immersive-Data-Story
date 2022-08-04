using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AcrossClassParameterManager : MonoBehaviour
{
    private static AcrossClassParameterManager m_instance;
    public static AcrossClassParameterManager Instance { get { return m_instance; } }

    public UIState CurrentUIState;


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
    }
    // Start is called before the first frame update
    void Start()
    {
        CurrentUIState = new UIState() { windowMode = "background", visualizationType = "trajectory", heatmapLayer="2", heatmapPage="all"};
    }
}
