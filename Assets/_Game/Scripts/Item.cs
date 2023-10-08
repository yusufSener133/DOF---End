using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Item : MonoBehaviour
{
    [SerializeField] private GameObject _growedEffect;
    [SerializeField] private ItemData _data;
    private GameObject go;
    public ItemData Data { get => _data; }

    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _animator.speed = Data.GrowingSpeed;
    }
    public void Collectable()
    {
        gameObject.GetComponent<Collider>().enabled = true;
        go = Instantiate(_growedEffect, transform);
    }
    public void IsGrowing()
    {
        gameObject.GetComponent<Collider>().enabled = false;
        Destroy(go);
    }
}/**/
