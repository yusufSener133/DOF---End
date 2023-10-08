using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _inventoryCount = 21;

    [SerializeField] private Inventory _inventory;

    public Inventory Inventory
    {
        get { return _inventory; }
        set { _inventory = value; }
    }

    private void Awake()
    {
        Inventory = new Inventory(_inventoryCount);
    }

}/**/
