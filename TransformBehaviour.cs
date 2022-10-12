
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

    public void Setv3Value()
    {
        v3Data.value = transform.position;
    }

    public IEnumerator SendTransform()
    {
        while (canRun.value)
        {
            Setv3Value();
            yield return wffu;
        }
    }
}
