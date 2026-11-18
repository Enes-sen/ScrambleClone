using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour,IMoveable
{
    [SerializeField] private PlayerFieldsSO _playerFields;
    private Rigidbody2D _rb2D;
    public void Move()
    {
        
    }
    void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var dir = (Vector2)transform.position + InputManager.Instance.MoveDirection 
        * _playerFields.Speed * Time.deltaTime;
        if()
    }
}