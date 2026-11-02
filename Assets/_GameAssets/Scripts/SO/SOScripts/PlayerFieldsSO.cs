using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerFieldsSO", menuName = "SO/PlayerFieldsSO")]
public class PlayerFieldsSO : ScriptableObject
{

    #region Settings
    [Header("Player Base Fields")]
    [SerializeField] private int _speed;
    [SerializeField] private int _maxHealth;
    [Header("Player Sfx Settings")]
    [SerializeField] private AudioClip[] _playerSoundsSfx;
    #endregion
    #region Getters
    public int Speed => _speed;
    public int MaxHealth => _maxHealth;
    public AudioClip[] PlayerSoundsSfx => _playerSoundsSfx;
    #endregion
}
