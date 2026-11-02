using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyFieldsSO", menuName = "SO/EnemyFieldsSO")]
public class EnemyFieldsSO : ScriptableObject
{
    [Header("Enemy Fields")]
    [SerializeField] private int _speed;
    public int Speed => _speed;
}
