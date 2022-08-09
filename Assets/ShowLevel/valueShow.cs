using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class valueShow : MonoBehaviour
{
    public Text valueText;
    public Slider slider;

    public GameObject winclose;
    public GameObject winopen;
    public GameObject withafan;

    public void OnSliderChanged(float value)
    {
        valueText.text = value.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log(GameObject.Find("Plane (1)").transform.position.z);
         Debug.Log(GameObject.Find("Plane (5)").transform.position.z);
         Debug.Log(GameObject.Find("Plane (8)").transform.position.z);
         Debug.Log(GameObject.Find("Plane (4)").transform.position.z);
         Debug.Log(GameObject.Find("Plane (2)").transform.position.x);
         Debug.Log(GameObject.Find("Plane (11)").transform.position.x);
         Debug.Log(GameObject.Find("Plane (9)").transform.position.x);
         Debug.Log(GameObject.Find("Plane (3)").transform.position.x);*/

        CheckActive();
        
    }


    private void CheckActive()
    {
       if (winclose.activeSelf)
        {
            //Debug.Log("winClose active!!");
            UpdateLevelWinClose();
        }
       if (winopen.activeSelf)
        {
            //Debug.Log("winOpen active!!");
            UpdateLevelWinOpen();
        }
        if (withafan.activeSelf)
        {
            //Debug.Log("fan active!!");\
            UpdateLevelFan();
        }

    }

    private void UpdateLevelWinClose()
    {
        //WinClose By default
        if (GameObject.Find("Main Camera").transform.position.x > -5.45 && GameObject.Find("Main Camera").transform.position.x < -1.63)
        {
            //Debug.Log(GameObject.Find("Main Camera").transform.position.x);
            if (GameObject.Find("Main Camera").transform.position.z > -0.22 && GameObject.Find("Main Camera").transform.position.z < 2.91)
            {
                slider.value = 5;  //area3
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 2.91 && GameObject.Find("Main Camera").transform.position.z < 5.05)
            {
                slider.value = 5;  //area6
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 5.05 && GameObject.Find("Main Camera").transform.position.z < 7.74)
            {
                slider.value = 4; //area9  value 3->4
            }
            else
            {
                slider.value = 0;
            }
        }
        else if (GameObject.Find("Main Camera").transform.position.x > -1.63 && GameObject.Find("Main Camera").transform.position.x < 0.63)
        {
            if (GameObject.Find("Main Camera").transform.position.z > -0.22 && GameObject.Find("Main Camera").transform.position.z < 2.91)
            {
                slider.value = 5; //area2
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 2.91 && GameObject.Find("Main Camera").transform.position.z < 5.05)
            {
                slider.value = 4; //area5
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 5.05 && GameObject.Find("Main Camera").transform.position.z < 7.74)
            {
                slider.value = 3; //area8
            }
            else
            {
                slider.value = 0;
            }
        }
        else if (GameObject.Find("Main Camera").transform.position.x > 0.63 && GameObject.Find("Main Camera").transform.position.x < 3.14)
        {
            if (GameObject.Find("Main Camera").transform.position.z > -0.22 && GameObject.Find("Main Camera").transform.position.z < 2.91)
            {
                slider.value = 3; //area1
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 2.91 && GameObject.Find("Main Camera").transform.position.z < 5.05)
            {
                slider.value = 3; //area4
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 5.05 && GameObject.Find("Main Camera").transform.position.z < 7.74)
            {
                slider.value = 2; //area7
            }
            else
            {
                slider.value = 0;
            }
        }
        else
        {
            slider.value = 0;
        }
    }


    private void UpdateLevelWinOpen()
    {
        //WinClose By default
        if (GameObject.Find("Main Camera").transform.position.x > -5.45 && GameObject.Find("Main Camera").transform.position.x < -1.63)
        {
            //Debug.Log(GameObject.Find("Main Camera").transform.position.x);
            if (GameObject.Find("Main Camera").transform.position.z > -0.22 && GameObject.Find("Main Camera").transform.position.z < 2.91)
            {
                slider.value = 5;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 2.91 && GameObject.Find("Main Camera").transform.position.z < 5.05)
            {
                slider.value = 3;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 5.05 && GameObject.Find("Main Camera").transform.position.z < 7.74)
            {
                slider.value = 2; //not 3
            }
            else
            {
                slider.value = 0;
            }
        }
        else if (GameObject.Find("Main Camera").transform.position.x > -1.63 && GameObject.Find("Main Camera").transform.position.x < 0.63)
        {
            if (GameObject.Find("Main Camera").transform.position.z > -0.22 && GameObject.Find("Main Camera").transform.position.z < 2.91)
            {
                slider.value = 3;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 2.91 && GameObject.Find("Main Camera").transform.position.z < 5.05)
            {
                slider.value = 3;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 5.05 && GameObject.Find("Main Camera").transform.position.z < 7.74)
            {
                slider.value = 2;
            }
            else
            {
                slider.value = 0;
            }
        }
        else if (GameObject.Find("Main Camera").transform.position.x > 0.63 && GameObject.Find("Main Camera").transform.position.x < 3.14)
        {
            if (GameObject.Find("Main Camera").transform.position.z > -0.22 && GameObject.Find("Main Camera").transform.position.z < 2.91)
            {
                slider.value = 2;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 2.91 && GameObject.Find("Main Camera").transform.position.z < 5.05)
            {
                slider.value = 2;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 5.05 && GameObject.Find("Main Camera").transform.position.z < 7.74)
            {
                slider.value = 1;
            }
            else
            {
                slider.value = 0;
            }
        }
        else
        {
            slider.value = 0;
        }
    }


    private void UpdateLevelFan()
    {
        //WinClose By default
        if (GameObject.Find("Main Camera").transform.position.x > -5.45 && GameObject.Find("Main Camera").transform.position.x < -1.63)
        {
            //Debug.Log(GameObject.Find("Main Camera").transform.position.x);
            if (GameObject.Find("Main Camera").transform.position.z > -0.22 && GameObject.Find("Main Camera").transform.position.z < 2.91)
            {
                slider.value = 5;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 2.91 && GameObject.Find("Main Camera").transform.position.z < 5.05)
            {
                slider.value = 3;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 5.05 && GameObject.Find("Main Camera").transform.position.z < 7.74)
            {
                slider.value = 1; //not 3
            }
            else
            {
                slider.value = 0;
            }
        }
        else if (GameObject.Find("Main Camera").transform.position.x > -1.63 && GameObject.Find("Main Camera").transform.position.x < 0.63)
        {
            if (GameObject.Find("Main Camera").transform.position.z > -0.22 && GameObject.Find("Main Camera").transform.position.z < 2.91)
            {
                slider.value = 2;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 2.91 && GameObject.Find("Main Camera").transform.position.z < 5.05)
            {
                slider.value = 2;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 5.05 && GameObject.Find("Main Camera").transform.position.z < 7.74)
            {
                slider.value = 1;
            }
            else
            {
                slider.value = 0;
            }
        }
        else if (GameObject.Find("Main Camera").transform.position.x > 0.63 && GameObject.Find("Main Camera").transform.position.x < 3.14)
        {
            if (GameObject.Find("Main Camera").transform.position.z > -0.22 && GameObject.Find("Main Camera").transform.position.z < 2.91)
            {
                slider.value = 1;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 2.91 && GameObject.Find("Main Camera").transform.position.z < 5.05)
            {
                slider.value = 1;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 5.05 && GameObject.Find("Main Camera").transform.position.z < 7.74)
            {
                slider.value = 1;
            }
            else
            {
                slider.value = 0;
            }
        }
        else
        {
            slider.value = 0;
        }
    }
}
