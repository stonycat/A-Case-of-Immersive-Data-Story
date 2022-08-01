using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    
    [SerializeField] public GameObject obj;
    public Material white;
    public Material blue;
    public List<GameObject> Children;


    public void ChangeColorToBlue()
    {
        obj.GetComponent<Renderer>().material = blue;
    }
    public void ChangeColorToWhite()
    {

        obj.GetComponent<Renderer>().material = white;
        /*
        foreach (Transform child in obj.transform)
        {
            Children.Add(child.gameObject);
        }
        foreach (GameObject a in Children)
        {
            a.GetComponentInChildren<Renderer>().material = white;
        }
        */


    }


}
