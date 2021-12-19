using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private int _speed = 3;
    [SerializeField] private GameObject _player;
    [SerializeField] private bool _isGrounded;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        _isGrounded = true;
        _animator.SetBool("Jump", false);

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += transform.forward * Speed * Time.deltaTime;
            transform.Translate(Vector3.forward * _speed * Time.deltaTime, Camera.main.transform);

            _animator.SetBool("IsWalkingForward", true);

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _animator.SetBool("IsWalkingForward", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * _speed * Time.deltaTime;
            _animator.SetBool("IsWalkingBack", true);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            _animator.SetBool("IsWalkingBack", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * _speed * Time.deltaTime;
            _animator.SetBool("IsWalkingRight", true);

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            _animator.SetBool("IsWalkingRight", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * _speed * Time.deltaTime;
            _animator.SetBool("IsWalkingLeft", true);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            _animator.SetBool("IsWalkingLeft", false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _isGrounded = false;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 300, 0));
            _animator.SetBool("Jump", true);
        }
    }
}
