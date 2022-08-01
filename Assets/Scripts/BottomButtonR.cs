using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class BottomButtonR : MonoBehaviour
{
    static bool open = true;
    bool openRay=false;
    public InputActionAsset inputActions;
    public GameObject ray;
    private Animator _anima;
    private InputAction _click;
    private InputAction _menu;
    private InputAction _ray;
    private InputAction _select;
    void Start()
    {
        _anima = GetComponent<Animator>();
        _click = inputActions.FindActionMap("XRI RightHand").FindAction("BottomButton");
        _click.Enable();
        _click.performed += MoveFinger;

        _menu = inputActions.FindActionMap("XRI LeftHand").FindAction("Menu");
        _menu.Enable();
        _menu.performed += OpenClose;

        _ray = inputActions.FindActionMap("XRI RightHand").FindAction("Ray");
        _ray.Enable();
        _ray.performed += OpenCloseRay;
        ray.GetComponent<XRInteractorLineVisual>().enabled = false;

        _select = inputActions.FindActionMap("XRI RightHand").FindAction("Select");
        _select.Disable();
    }
    
    // Update is called once per frame
    public void MoveFinger(InputAction.CallbackContext context)
    {
        _anima.Play("bottomButtonR");
    }

    public void OpenClose(InputAction.CallbackContext context)
    {
        if (open)
        {
            _anima.Play("closeR");
            open = false;
            _click.performed -= MoveFinger;
        }
        else
        {
            _anima.Play("openR");
            open = true;
            _click.performed += MoveFinger;
        }

    }

    public void OpenCloseRay(InputAction.CallbackContext context) //A °´¼ü
    {
        if (openRay)
        {
            ray.GetComponent<XRInteractorLineVisual>().enabled = false;
            _select.Disable();
            openRay = false;
        }
        else
        {
            ray.GetComponent<XRInteractorLineVisual>().enabled = true;
            _select.Enable();
            openRay = true;
        }

    }
}

