using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Para usar TextMeshPro

public class Result : MonoBehaviour
{
    public TMP_Text[] numberTexts;
    public TMP_Text resultText;
    public int maxRepetitions;

    // M�todo que cuenta cu�ntas veces se repite el n�mero que m�s veces aparece
    void Update()
    {
        
    }

    public void ButtonPress()
    {
        Invoke("CheckNumbers", 3);
    }

    public void CheckNumbers()
    {
        Dictionary<int, int> numberCount = new Dictionary<int, int>();
        int[] numbers = new int[numberTexts.Length];

        // Obtener los n�meros de los textos
        for (int i = 0; i < numberTexts.Length; i++)
        {
            // Convertimos el texto del TMP_Text a n�mero entero
            numbers[i] = int.Parse(numberTexts[i].text);
        }

        // Cuenta las veces que aparece cada n�mero
        foreach (int number in numbers)
        {
            if (numberCount.ContainsKey(number))
            {
                numberCount[number]++;
            }
            else
            {
                numberCount[number] = 1;
            }
        }

        // Encuentra el n�mero con m�s repeticiones
        maxRepetitions = 0;
        foreach (var pair in numberCount)
        {
            if (pair.Value > maxRepetitions)
            {
                maxRepetitions = pair.Value;
            }
        }

        // Muestra el resultado (cantidad de veces que se repite el n�mero m�s repetido)
        if (maxRepetitions <= 1)
        {
            resultText.text = "Reps: 0";
        }
        else
        {
            resultText.text = "Reps: " + maxRepetitions;

        }
    }
}
