using UnityEngine;
using UnityEngine.Events;

public class DetectCollision2D : MonoBehaviour
{
    public UnityEvent collisionEvent;
    
    
    void OnCollisionEnter2D()  // Once the Trigger has been entered record collision in the argument variable "other"
    {
        collisionEvent.Invoke();
    }
}
