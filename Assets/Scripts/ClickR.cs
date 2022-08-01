using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickR : MonoBehaviour
{
    // Start is called before the first frame update
    public InputActionAsset inputActions;
    private Animator _anima;
    private InputAction _click;

    void Start()
    {
        _anima = GetComponent<Animator>();
        _click = inputActions.FindActionMap("XRI RightHand").FindAction("Click");
        _click.Enable();
        _click.performed += MoveFinger;
        
    }

    // Update is called once per frame
    public void MoveFinger(InputAction.CallbackContext context)
    {
        _anima.Play("ClickR");
    }
}
