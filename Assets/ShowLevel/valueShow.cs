using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class valueShow : MonoBehaviour
{
    public Text valueText;
    public Slider slider;

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
                slider.value = 5;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 5.05 && GameObject.Find("Main Camera").transform.position.z < 7.74)
            {
                slider.value = 4; //not 3
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
                slider.value = 5;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 2.91 && GameObject.Find("Main Camera").transform.position.z < 5.05)
            {
                slider.value = 4;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 5.05 && GameObject.Find("Main Camera").transform.position.z < 7.74)
            {
                slider.value = 3;
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
                slider.value = 3;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 2.91 && GameObject.Find("Main Camera").transform.position.z < 5.05)
            {
                slider.value = 3;
            }
            else if (GameObject.Find("Main Camera").transform.position.z > 5.05 && GameObject.Find("Main Camera").transform.position.z < 7.74)
            {
                slider.value = 3;
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
