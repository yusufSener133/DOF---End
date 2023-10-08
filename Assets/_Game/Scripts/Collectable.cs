using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Item))]
public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player)
        {
            Item item = GetComponent<Item>();
            if (item)
            {
                player.Inventory.Add(item);
                GetComponent<Animator>().SetTrigger("Collected");
                GameManager.Instance.InventoryUI.Refresh();
            }
        }
    }
}/**/
