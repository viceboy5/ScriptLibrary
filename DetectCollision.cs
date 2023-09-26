using UnityEngine;
using UnityEngine.Events;

public class DetectCollision : MonoBehaviour
{
    public UnityEvent collisionEvent;
    
    
    void OnCollisionEnter()  // Once the Trigger has been entered record collision in the argument variable "other"
    {
        collisionEvent.Invoke();
    }
}
