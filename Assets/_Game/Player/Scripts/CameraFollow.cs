using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _player;
    private Vector3 _offSet;
    void Start()
    {
        _offSet = _player.position - transform.position;
    }

    void LateUpdate()
    {
        transform.position = _player.position - _offSet;
    }
}/**/
