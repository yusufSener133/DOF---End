using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Item : MonoBehaviour
{
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
    }
    public void IsGrowing()
    {
        gameObject.GetComponent<Collider>().enabled = false;
    }
}/**/
