using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetMoney : MonoBehaviour
{
    public TMP_Text text; // Asigna este campo en el Inspector
    private Result result;
    public float money = 100;
    public float bettingMoney;

    // Start is called before the first frame update
    void Start()
    {
        // Encuentra el script Result en un objeto hijo o hermano
        result = transform.parent.GetComponentInChildren<Result>();
    }

    public void BttnPress()
    {
        Invoke("showText", 5);
    }

    // Update is called once per frame
    public void showText()
    {
        switch(result.maxRepetitions)
        {
            case 0:
                money -= bettingMoney;
                break;
            case 1:
                money -= (bettingMoney * 0.5f);
                break;
            case 2:
                money -= ((bettingMoney * 0.5f));
                break;
            case 3:
                break;
            case 4:
                money += bettingMoney;
                break;
            case 5:
                money += bettingMoney * 2;
                break;
            default:
            break;

        }
        text.text = money.ToString(); // Actualiza el texto con la variable del otro script

    }
}
