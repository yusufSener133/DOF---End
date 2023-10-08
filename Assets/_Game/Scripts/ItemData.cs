using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item Data", menuName = "Item Data", order = 50)]
public class ItemData : ScriptableObject
{
    public string ItemName = "Item Name";
    public Sprite Icon;
    public int Value = 1;
    [Range(0, 1)] public float GrowingSpeed = 1f;
}/**/
