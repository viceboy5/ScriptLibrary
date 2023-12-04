using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;

    public void SetValue(float num)
    {
        value = num;
    }

    public void UpdateValue (float num)
    {
        value += num;
    }

    public void MatchValueX(GameObject obj)
    {
        value = obj.transform.position.x;
    }
    
    public void MatchValueY(GameObject obj)
    {
        value = obj.transform.position.y;
    }
    
    public void MatchValueZ(GameObject obj)
    {
        value = obj.transform.position.z;
    }
    
    public void CompareValue(FloatData obj)
    {
        if (value >= obj.value)
        {

        }
        else
        {
            value = obj.value;
        }
        
    }
}
