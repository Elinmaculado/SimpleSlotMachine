using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BttnActivation : MonoBehaviour
{
    public GameObject button;
    public int waitTime;
    public Button thisButton;

    public void OnEnable()
    {
        thisButton.interactable = true;
    }
    public void ButtonPress()
    {
        thisButton.interactable = false;
        Invoke("ActivateBttn", waitTime);
    }
    public void ActivateBttn()
    {
       button.SetActive(true);
       gameObject.SetActive(false);
    }
}
