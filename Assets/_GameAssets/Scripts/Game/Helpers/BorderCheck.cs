using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCheck : MonoBehaviour
{
    Camera _camera;
    Vector2 _screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
        _screenBounds = _camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, _camera.transform.position.z));
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -_screenBounds.x, _screenBounds.x),
            Mathf.Clamp(transform.position.y, -_screenBounds.y, _screenBounds.y),
            transform.position.z
        );
    }
}
