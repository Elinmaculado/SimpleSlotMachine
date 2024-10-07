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
        

    }

    public void PlusButton()
    {
        bettingMoney += 5;
        money -= 5;
    }

    public void MinusButton()
    {
        if (bettingMoney < 0)
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
        moneyText.text = money.ToString();
        betText.text = bettingMoney.ToString();
    }
}
