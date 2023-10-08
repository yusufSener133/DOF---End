using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FarmUI : MonoBehaviour
{
    [SerializeField] private GameObject _upgradePanel, _maxPanel;
    [SerializeField] private TMP_Text _upgradeText, _costText;
    [SerializeField] private float _value = 10;
    private Farm _farm;
    private int _count = 0;
    private void Awake()
    {
        _farm = GetComponent<Farm>();
    }
    private void Start()
    {
        UpdateCostText();
    }
    public void UpgradeFarmButton()
    {
        if (_count == 4)
        {
            _upgradePanel.SetActive(false);
            _maxPanel.SetActive(true);
            return;
        }
        if (GameManager.Instance.Coin >= _value)
        {
            _upgradeText.text = "Upgrade";
            _farm.UpgradeFarm(_count);
            GameManager.Instance.Coin -= _value;
            _value *= 2;
            _count++;
            UpdateCostText();
        }
    }
    private void UpdateCostText()
    {
        _costText.text = "$" + _value;
    }

}/**/
