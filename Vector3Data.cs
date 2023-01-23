using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 value;
    
    public void SetValue(float x, float y, float z)
    {
        value.Set(x,y,z);
    }
}
