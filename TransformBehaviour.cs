
using System;
using System.Collections;
using UnityEngine;

public class TransformBehaviour : MonoBehaviour
{
    public Vector3Data v3Data;
    private WaitForFixedUpdate wffu;
    public BoolData canRun;
    
    
    public void ResetToZero()
    {
        transform.position = Vector3.zero;
    }

    public void SetV3Value()
    {
        v3Data.value = transform.position;
    }

    private IEnumerator SendTransform()
    {
        if (canRun.value)
        {
            SetV3Value();
            Debug.Log("setting transform V3");
            yield return wffu;
            
        }
    }
}
