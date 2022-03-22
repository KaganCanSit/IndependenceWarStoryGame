using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LangDropdown : MonoBehaviour
{
    public TextMeshProUGUI output;
    string lang;

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            lang = "en";
            Debug.Log("English");
        }
        else if (val == 1)
        {
            lang = "tr";
            Debug.Log("Turkce");
        }
    }
}
