using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_InputWindow : MonoBehaviour
{
    public string username;
    public string company;
    public GameObject nameField;
    public GameObject companyField;
    public GameObject textDisplay;
    public GameObject userDetailsPanel;

    public void StoreUserDetails()
    {
        username = nameField.GetComponent<TextMeshProUGUI>().text;
        company = companyField.GetComponent<TextMeshProUGUI>().text;
        textDisplay.GetComponent<TextMeshProUGUI>().text = $"{company} \n Welcome, {username}";
    }
    public void HidePanel()
    {
       userDetailsPanel.SetActive(false);
    }
}
