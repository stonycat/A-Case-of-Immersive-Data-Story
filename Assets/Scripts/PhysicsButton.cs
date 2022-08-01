using System;
using UnityEngine;
using UnityEngine.Events;

public class PhysicsButton : MonoBehaviour
{
    [SerializeField] private float threshold = 0.5f;
    [SerializeField] private float deadZone = 0.025f;
    /*[SerializeField] public Hand leftHand;
    [SerializeField] public Hand rightHand;
*/
    //private Collider[] colsLeft;
    //private Collider[] colsRight;
    private bool _isPressed;
    private Vector3 _startPos;
    private ConfigurableJoint _joint;
    public UnityEvent onPressed, onReleased;
    


    void Start()
    {
        _startPos = transform.localPosition;
        _joint = GetComponent<ConfigurableJoint>();

        //Collider[] colsLeft = leftHand.GetComponentsInChildren<CapsuleCollider>();
        //Collider[] colsRight = leftHand.GetComponentsInChildren<CapsuleCollider>();

    }

    void Update()
    {
        if (!_isPressed && GetValue() + threshold >= 1)
        {
            Pressed();
            //Physics.IgnoreCollision(this.GetComponent<Collider>(), hand.GetComponent<Collider>(), true);
        }
        if (_isPressed && GetValue() - threshold <= 0)
        {
            Released();
            //Physics.IgnoreCollision(this.GetComponent<Collider>(), hand.GetComponent<Collider>(), true);
        }
            
    }
    private float GetValue()
    {
        var value = Vector3.Distance(_startPos, transform.localPosition) / _joint.linearLimit.limit;
        if (Math.Abs(value) < deadZone)
            value = 0;

        return Mathf.Clamp(value, -1f, 1f);
    }

    private void Pressed()
    {
        _isPressed = true;   
        onPressed.Invoke();
        /*foreach (Collider col in colsRight)
        {
            Debug.Log(col.name);
            if (!col.isTrigger)
            {
                col.enabled = false;
                //col.enabled = true;
            }
        }*/
        Debug.Log("Pressed");
    }

    private void Released()
    {
        _isPressed = false;
        onReleased.Invoke();
        Debug.Log("Released");
    }

  


}
