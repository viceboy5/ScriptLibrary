using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 value;
    public Vector3 newValue;
    public void SetValue()
    {
        value = newValue;
    }

}
