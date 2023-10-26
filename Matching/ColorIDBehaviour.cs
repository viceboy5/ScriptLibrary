// written with Anthony Romrell at UVU
using UnityEngine;

public class ColorIDBehaviour : IDContainerBehaviour
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
