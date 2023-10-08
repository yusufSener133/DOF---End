using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private ItemManager _itemManager;
    public ItemManager ItemManager { get => _itemManager; }

    [SerializeField] private InventoryUI _inventoryUI;
    public InventoryUI InventoryUI { get => _inventoryUI; }
    [SerializeField] private Player _player;

    public Player Player
    {
        get { return _player; }
        set { _player = value; }
    }
    [SerializeField] private float _coin;

    public float Coin
    {
        get { return _coin; }
        set
        {
            _coin = value;
            PlayerPrefs.SetFloat("Coin", _coin);
        }
    }

    private void Awake()
    {
        if (Instance != this && Instance != null)
            Destroy(this.gameObject);
        else
            Instance = this;

        _itemManager = GetComponent<ItemManager>();
    }

}/**/
