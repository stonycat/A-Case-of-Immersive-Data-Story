using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    public InputActionAsset inputActions;
    private Canvas _canv;
    private InputAction _menu;

    public GameObject fanColor;
    public GameObject winClose;
    public GameObject winOpen;


    void Start()
    {
        _canv = GetComponent<Canvas>();
        _menu = inputActions.FindActionMap("XRI LeftHand").FindAction("Menu");
        _menu.Enable();
        _menu.performed += ToggleMenu;
        _canv.enabled = false;

    }

    // Update is called once per frame
    public void ToggleMenu(InputAction.CallbackContext context)  //X°´¼ü
    {
        _canv.enabled = !_canv.enabled;

        if(!_canv.enabled)
        {
            fanColor.SetActive(false);
            winClose.SetActive(false);
            winOpen.SetActive(false);
        }
    }
}
