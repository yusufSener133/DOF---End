using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farm : MonoBehaviour
{
    [SerializeField] private GameObject[] _products;
    [SerializeField] private GameObject _dirtCanvas;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _dirtCanvas.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _dirtCanvas.SetActive(false);
        }
    }
    public void UpgradeFarm(int count)
    {
        _products[count].SetActive(true);
    }

}/**/
