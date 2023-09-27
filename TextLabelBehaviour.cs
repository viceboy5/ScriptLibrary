using System;
using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(TextMeshProUGUI))]

public class TextLabelBehaviour : MonoBehaviour
{
    private TextMeshProUGUI label;
    public UnityEvent startEvent, updateEvent;

    private void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
    }

    private void Update()
    {
        updateEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

}
