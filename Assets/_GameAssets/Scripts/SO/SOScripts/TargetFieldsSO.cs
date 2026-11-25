using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TargetFieldsSO", menuName = "SO/TargetFieldsSO")]
public class TargetFieldsSO : ScriptableObject
{
    #region Fields
    // Serialized Fields
    [Header("Target Fields")]
    [SerializeField] private int _points;
    [SerializeField] private TargetEnum _targetType;
    #endregion
    #region Getters
    // Getters
    public int Points => _points;
    public TargetEnum TargetType => _targetType;
    #endregion
}