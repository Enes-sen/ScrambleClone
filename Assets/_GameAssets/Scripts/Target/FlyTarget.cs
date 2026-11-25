using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyTarget : MonoBehaviour,IMoveable,IDestroyable
{
    [Header("Target Fields")]
    [SerializeField] private TargetFieldsSO _targetFieldsSO;
    [SerializeField] private float _speed;
    public void Destroy()
    {
        //throw new System.NotImplementedException();
    }

    public void Move(Vector2 mDir)
    {
        //throw new System.NotImplementedException();
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
