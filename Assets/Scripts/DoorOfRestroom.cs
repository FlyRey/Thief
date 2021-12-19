using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOfRestroom : MonoBehaviour
{
    [SerializeField] private Transform _door;
    private float _speedOfOpen = 3;
    private bool _open;
    private bool _enter;
    private Vector3 _defaultRotation;
    private Vector3 _openRotation;

    private void Start()
    {
        _defaultRotation = _door.transform.eulerAngles;
        _openRotation = new Vector3(_defaultRotation.x, _defaultRotation.y + 90, _defaultRotation.z);
    }

    private void Update()
    {
        if (_open)
        {
            _door.transform.eulerAngles = Vector3.Slerp(_door.transform.eulerAngles, _openRotation, _speedOfOpen * Time.deltaTime);
        }
        else
        {
            _door.transform.eulerAngles = Vector3.Slerp(_door.transform.eulerAngles, _defaultRotation, _speedOfOpen * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.E) && _enter)
        {
            _open = !_open;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<Player>();
        if (player != null)
        {            
                _enter = true;
                Debug.Log("Нажмите E что бы открыть дверь");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var player = other.GetComponent<Player>();
        if (player != null)
        { 
                _enter = false;
        }
    }
}
