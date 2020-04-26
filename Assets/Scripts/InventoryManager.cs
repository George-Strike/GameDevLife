using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public interface IInventoryManager
{
    void CalculateCash();
}
public class InventoryManager : MonoBehaviour, IInventoryManager
{
    public int fanCount;
    public int cashCount;
    public DateTime dateTime;
    public GameObject cashField;
    public GameObject fanField;
    public GameObject dateField;
    public GameObject canvasField;
    public GameObject devCostField;

    public void CalculateCash()
    {
        string cash = cashField.GetComponent<TextMeshProUGUI>().text;
        int devCost = int.Parse(devCostField.GetComponent<TextMeshProUGUI>().text);
        int finalCost = int.Parse(cash) - devCost;
        cashField.GetComponent<TextMeshProUGUI>().text = finalCost.ToString();
    }

    void Start()
    {
    }
}
