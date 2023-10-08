using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text _coinText;
    void Update()
    {
        _coinText.text = GameManager.Instance.Coin + "";
    }



}/**/
