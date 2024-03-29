using TMPro;
using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void CompareValue(IntData obj)
    {
        if (value >= obj.value)
        {

        }
        else
        {
            value = obj.value;
        }
        
    }

    public void SetValue (IntData obj)
    {
        value = obj.value;
    }

    public void UpdateValue(int number)
    {
        value += number;
    }

    public void DisplayNumber(TextMeshProUGUI txt)
    {
        txt.text = value.ToString();
    }
    
    public void Save()
    {
        PlayerPrefs.SetInt("savedValue", value);
    }

    public void Load()
    {
        value = PlayerPrefs.GetInt("savedValue");
    }

}
