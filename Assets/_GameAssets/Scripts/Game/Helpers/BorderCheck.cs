using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCheck : MonoBehaviour
{
    Camera _camera;
    Vector2 _screenBounds;
    [SerializeField] Vector2 _objectBuffer;

    void Start()
    {
        _camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        _screenBounds = _camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, _camera.transform.position.z));
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -_screenBounds.x + _objectBuffer.x/2, _screenBounds.x - _objectBuffer.x/2),
            Mathf.Clamp(transform.position.y, -_screenBounds.y + _objectBuffer.y, _screenBounds.y - _objectBuffer.y),
            transform.position.z
        );
        var horizontalCheck = (Mathf.Abs(_screenBounds.x) + Mathf.Abs(_objectBuffer.x))/2;
        if (Mathf.Abs(transform.position.x) != horizontalCheck)
        {
            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x, -_screenBounds.x + _objectBuffer.x/2, _screenBounds.x - _objectBuffer.x/2),
                transform.position.y,
                transform.position.z
            );
        }
    }
}
