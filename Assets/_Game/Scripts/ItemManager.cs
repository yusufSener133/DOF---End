using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public Item[] items;

    public Dictionary<string, Item> NameToItemDict = new Dictionary<string, Item>();

    private void Awake()
    {
        foreach (Item item in items)
        {
            AddItem(item);
        }
    }

    private void AddItem(Item item)
    {
        if (!NameToItemDict.ContainsKey(item.Data.ItemName))
            NameToItemDict.Add(item.Data.ItemName, item);
    }
    public Item GetItemByName(string key) => NameToItemDict.ContainsKey(key) ? NameToItemDict[key] : null;
}/**/
