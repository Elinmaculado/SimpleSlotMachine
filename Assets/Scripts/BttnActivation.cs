using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BttnActivation : MonoBehaviour
{
    public GameObject buttons;
    public Button thisButton;
    public Button plus;
    public Button minus;

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
        plus.enabled = false;
        minus.enabled= false;

        // Si quieres reactivar los botones despu�s de que caigan los n�meros, puedes usar un tiempo basado en la duraci�n de la animaci�n
        Invoke("ReactivateButtons", 5);  // Cambia el 5 por la duraci�n de la animaci�n.
    }

    private void ReactivateButtons()
    {
        plus.enabled = true;
        minus.enabled= true;
    }
}
