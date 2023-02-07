using UnityEngine;
using UnityEngine.Events;

public class DetectTrigger : MonoBehaviour
{
    public UnityEvent triggerEvent;
    void OnTriggerEnter2D(Collider2D other)  // Once the Trigger has been entered record collision in the argument variable "other"
    {
        triggerEvent.Invoke();
    }
}