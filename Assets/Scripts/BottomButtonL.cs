using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class BottomButtonL : MonoBehaviour
{
    static bool open = true;
    public InputActionAsset inputActions;
    private Animator _anima;
    private InputAction _click;
    private InputAction _menu;
    void Start()
    {
        _anima = GetComponent<Animator>();
        _click = inputActions.FindActionMap("XRI LeftHand").FindAction("BottomButton");
        _click.Enable();
        _click.performed += MoveFinger;
        _menu = inputActions.FindActionMap("XRI LeftHand").FindAction("Menu");
        _menu.Enable();
        _menu.performed += OpenClose;
        

    }
    
    // Update is called once per frame
    public void MoveFinger(InputAction.CallbackContext context)
    {
        _anima.Play("bottomButtonL");
    }
    public void OpenClose(InputAction.CallbackContext context) // open menu
    {

        if (open)
        {
            _anima.Play("close");
            open = false;
            _click.performed -= MoveFinger;
        }
        else
        {
            _anima.Play("open");
            open = true;
            _click.performed += MoveFinger;

        }

    }
}

