using UnityEngine;

public abstract class BaseEventLogger : MonoBehaviour
{
    public abstract void StartListening();

    public abstract void StopListening();
}