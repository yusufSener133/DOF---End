using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private LayerMask _layerMask;
    private Rigidbody _rigidbody;
    private Animator _animator;
    private RaycastHit hit;

    [SerializeField] private float _speed;
    [SerializeField] private float _turnSpeed = 10f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        Moving();
    }

    private void Moving()
    {
        TargetPosition();

        var targetRotation = Quaternion.LookRotation(new Vector3(_target.position.x - transform.position.x, 0, _target.position.z - transform.position.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, _turnSpeed * Time.deltaTime);

        if (Mathf.Abs(_target.position.magnitude - transform.position.magnitude) > .2f)
        {
            _rigidbody.velocity = transform.forward * _speed;
            _animator.SetBool("isMoving", true);
        }
        else
        {
            _animator.SetBool("isMoving", false);
            _target.gameObject.SetActive(false);
        }
    }
    private void TargetPosition()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _target.gameObject.SetActive(true);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, _layerMask))
                _target.transform.position = new Vector3(hit.point.x, transform.position.y, hit.point.z);
        }
    }
}/**/
