using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform dotOfCamera;
    public float SpeedCam = 15;

    private bool _isActive;
    private float _x;
    private float _y;


    void LateUpdate()
    {
        _x = Input.GetAxis("Mouse X") * SpeedCam * 10;
        _y = Input.GetAxis("Mouse Y") * -SpeedCam * 10;

        if (Input.GetMouseButtonDown(1))
        {
            _isActive = true;
        }

        if (Input.GetMouseButtonUp(1))
        {
            _isActive = false;
        }

        if (_isActive)
        {
            transform.RotateAround(dotOfCamera.transform.position, transform.up, _x * Time.deltaTime);
            transform.RotateAround(dotOfCamera.transform.position, transform.right, _y * Time.deltaTime);
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
        }
    }
}
