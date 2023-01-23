using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 value;
    public void SetValue(Vector3Data newV3)
    {
        value = newV3.value;
    }

}
