using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inventory
{
    [System.Serializable]
    public class Slot
    {
        public Sprite icon;
        public string itemName;
        public int Count;
        public int MaxAllowed;
        public Slot()
        {
            itemName = "";
            Count = 0;
            MaxAllowed = 99;
        }
        public bool CanAddItem() => Count < MaxAllowed;
        public void AddItem(Item item)
        {
            itemName = item.Data.ItemName;
            icon = item.Data.Icon;
            Count++;
        }
        public bool IsEmpty() => itemName == "" && Count == 0 ? true : false;
        public void RemoveItem()
        {
            if (Count > 0)
            {
                Count--;
                if (Count == 0)
                {
                    icon = null;
                    itemName = "";
                }
            }
        }
    }
    public List<Slot> slots = new List<Slot>();
    public Inventory(int numSlots)
    {
        for (int i = 0; i < numSlots; i++)
        {
            Slot slot = new Slot();
            slots.Add(slot);
        }
    }
    public void Add(Item item)
    {
        foreach (Slot slot in slots)
        {
            if (slot.itemName == item.Data.ItemName && slot.CanAddItem())
            {
                slot.AddItem(item);
                return;
            }
        }
        foreach (Slot slot in slots)
        {
            if (slot.itemName == "")
            {
                slot.AddItem(item);
                return;
            }
        }
    }
    public void Remove(int index)
    {
        slots[index].RemoveItem();
    }
}/**/
