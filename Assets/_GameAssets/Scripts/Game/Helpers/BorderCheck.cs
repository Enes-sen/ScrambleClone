using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCheck : MonoBehaviour
{
    Camera _camera;
    [SerializeField] Vector2 _screenBounds;
    [SerializeField] Vector2 _objectBuffer;

    void Start()
    {
        _camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        _screenBounds = _camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, _camera.transform.position.z));
        _screenBounds.x /= 2;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -_screenBounds.x + _objectBuffer.x, _screenBounds.x - _objectBuffer.x),
            Mathf.Clamp(transform.position.y, -_screenBounds.y + _objectBuffer.y, _screenBounds.y - _objectBuffer.y),
            transform.position.z
        );
    }
}