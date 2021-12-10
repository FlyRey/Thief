using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private int Speed = 3;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
             transform.position += transform.forward * Speed * Time.deltaTime;
            _animator.SetBool("IsWalkingForward", true);

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _animator.SetBool("IsWalkingForward", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Speed * Time.deltaTime;
            _animator.SetBool("IsWalkingBack", true);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            _animator.SetBool("IsWalkingBack", false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Speed * Time.deltaTime;
            _animator.SetBool("IsWalkingRight", true);

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            _animator.SetBool("IsWalkingRight", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Speed * Time.deltaTime;
            _animator.SetBool("IsWalkingLeft", true);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            _animator.SetBool("IsWalkingLeft", false);
        }
    }
}
