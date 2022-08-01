using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonAngle : MonoBehaviour
{

    public GameObject person;
    public GameObject rig;
    public GameObject prig;
    public GameObject but;

    public GameObject leftHand;
    public GameObject rightHand;

    public void EnterPersonAngle()
    {
        person.SetActive(false);
        rig.SetActive(false);
        prig.SetActive(true);
        but.SetActive(false);

        leftHand.SetActive(false);
        rightHand.SetActive(false);
    }
    public void ExitPersonAngle()
    {
        person.SetActive(true);
        prig.SetActive(false);
        rig.SetActive(true);
        but.SetActive(true);

        leftHand.SetActive(true);
        rightHand.SetActive(true);
    }

}
