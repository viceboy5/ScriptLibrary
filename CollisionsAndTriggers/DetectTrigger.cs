using UnityEngine;
using UnityEngine.Events;

public class DetectTrigger : MonoBehaviour
{
    public UnityEvent triggerEvent;
    void OnTriggerEnter(Collider other)  // Once the Trigger has been entered record collision in the argument variable "other"
    {
        triggerEvent.Invoke();
        Debug.Log("triggerdetected");
    }
}