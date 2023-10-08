using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private GameObject _inventoryPanel;
    [SerializeField] private Player _player;//.

    public List<SlotUI> slots = new List<SlotUI>();
    //...
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
            ToggleInventory();
        if (Input.GetKeyDown(KeyCode.R))
            Remove(0);
    }
    //...
    public void ToggleInventory()
    {
        Refresh();
        _inventoryPanel.SetActive(!_inventoryPanel.activeSelf);
    }

    public void Refresh()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (_player.Inventory.slots[i].itemName != "")
                slots[i].SetItem(_player.Inventory.slots[i]);
            else
                slots[i].SetEmpty();
        }
    }
    public void Sell(int slotId)
    {
        Item item = GameManager.Instance.ItemManager.GetItemByName(_player.Inventory.slots[slotId].itemName);
        Remove(slotId);
        GameManager.Instance.Coin += item.Data.Value;
    }
    public void SellAll(int slotId)
    {
        Item item = GameManager.Instance.ItemManager.GetItemByName(_player.Inventory.slots[slotId].itemName);
        while (_player.Inventory.slots[slotId].Count != 0)
        {
            Remove(slotId);
            GameManager.Instance.Coin += item.Data.Value;
        }
    }
    public void Remove(int slotId)
    {
        Item item = GameManager.Instance.ItemManager.GetItemByName(_player.Inventory.slots[slotId].itemName);
        if (item != null)
        {
            _player.Inventory.Remove(slotId);
            Refresh();
        }
    }
}/**/
