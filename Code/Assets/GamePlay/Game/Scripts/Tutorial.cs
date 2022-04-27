using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public GameObject tuto;
    public Text txt;

    public void MakeVisible()
    {
        this.tuto.SetActive(true);
        Invoke("MakeInvisible", 7);
    }

    public void MakeInvisible()
    {
        this.tuto.SetActive(false); ;
    }

    public void ChangeText(string tutoText)
    {
        this.txt.text = tutoText;
    }
}
