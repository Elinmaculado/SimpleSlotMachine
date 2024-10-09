using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BttnActivation : MonoBehaviour
{
    public GameObject buttons;
    public Button thisButton;
    public Button plus;
    public Button minus;

    public TMP_Text betText;

    private void Update()
    {
        if (betText.text == "$0")
        {
            thisButton.interactable = false;
        }
        else
        {
            thisButton.interactable = true;
        }
    }
    public void OnEnable()
    {
        thisButton.interactable = true;
    }

    public void ButtonPress()
    {
        thisButton.interactable = false;
        ActivateBttn();
    }

    public void ActivateBttn()
    {
        buttons.SetActive(true);
        gameObject.SetActive(false);
    }

    public void StopPress()
    {
        // Desactivar botones de apuesta inmediatamente
        thisButton.interactable = false;
        plus.enabled = false;
        minus.enabled= false;

        Invoke("ReactivateButtons", 3); 
        Invoke("ActivateBttn", 3);  
    }

    private void ReactivateButtons()
    {
        plus.enabled = true;
        minus.enabled= true;
    }
}
