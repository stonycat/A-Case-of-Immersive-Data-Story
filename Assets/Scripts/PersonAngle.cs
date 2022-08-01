using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonAngle : MonoBehaviour
{

    public GameObject person;
    public GameObject rig;
    public GameObject prig;
    public GameObject but;

    public void EnterPersonAngle()
    {
        person.SetActive(false);
        rig.SetActive(false);
        prig.SetActive(true);
        but.SetActive(false);
    }
    public void ExitPersonAngle()
    {
        person.SetActive(true);
        prig.SetActive(false);
        rig.SetActive(true);
        but.SetActive(true);
    }
}
