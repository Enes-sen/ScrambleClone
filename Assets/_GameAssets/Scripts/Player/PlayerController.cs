using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour,IMoveable
{
    [SerializeField] private PlayerFieldsSO _playerFields;
    private Rigidbody2D _rb2D;
   
    void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var dir = transform.right * InputManager.Instance.MoveDirection.x + transform.up * InputManager.Instance.MoveDirection.y;
        if(InputManager.Instance.MoveDirection != Vector2.zero)
        {
            Move(dir);
        }
        else
        {
            _rb2D.velocity = Vector2.zero;
        }
    }
     public void Move( Vector2 mDir)
    {
        _rb2D.MovePosition(_rb2D.position + mDir * _playerFields.Speed * Time.fixedDeltaTime);
    }
}