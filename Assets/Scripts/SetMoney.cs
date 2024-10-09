using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetMoney : MonoBehaviour
{
    public TMP_Text moneyText;
    public TMP_Text betText;
    public Button plusButton;
    public Button minusButton;
    private Result result;
    public float money = 100;
    public float bettingMoney = 0;

    public GameObject losePanel;

    // Start is called before the first frame update
    void Start()
    {
        result = transform.parent.GetComponentInChildren<Result>();
    }

    public void BttnPress()
    {
        Invoke("showText", 3);
    }

    // Update is called once per frame
    public void showText()
    {
        switch(result.maxRepetitions)
        {
            case 0:
                // Pierdes tu dinero
                break;
            case 1:
                // Te regresa la mitad
                money += (bettingMoney/2);
                break;
            case 2:
                // Te regresa  tu dinero
                money += bettingMoney;
                break;
            case 3:
                // Te regresa el dinero y además ganas lo que apostaste
                money += bettingMoney * 2;
                break;
            default:
            break;

        }
        bettingMoney = 0;

    }

    public void PlusButton()
    {
        if (money <= 0)
        {
            money = 0;
            return;
        }
        else
        {
            bettingMoney += 5;
            money -= 5;
        }
    }

    public void MinusButton()
    {
        if (bettingMoney <= 0)
        {
            return;
        }
        else
        {
            bettingMoney -= 5;
            money += 5;
        }
    }

    public void Update()
    {
        if (money <= 0)
        {
            plusButton.interactable = false;
        }
        else
        {
            plusButton.interactable = true;
        }

        if (bettingMoney <= 0)
        {
            minusButton.interactable = false;
        }
        else
        {
            minusButton.interactable = true;
        }
        moneyText.text = "$" + money.ToString();
        betText.text = "$" + bettingMoney.ToString();

        if (bettingMoney <= 0 && money <= 0)
        {
            losePanel.SetActive(true);
        }
    }
}
