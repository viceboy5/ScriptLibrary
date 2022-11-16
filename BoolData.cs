using UnityEngine;

[CreateAssetMenu]
public class BoolData : ScriptableObject
{
    public bool value;

    public void SetValue(bool currentValue)
    {
        value = currentValue;
    }
}
