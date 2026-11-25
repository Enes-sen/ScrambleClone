using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuelTarget : MonoBehaviour,IDestroyable
{
    [Header("Target Fields")]
    [SerializeField] private TargetFieldsSO _targetFieldsSO;
    public void Destroy()
    {
        //throw new System.NotImplementedException();
    }

    
}
