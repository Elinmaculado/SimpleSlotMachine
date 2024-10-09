using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Para usar TextMeshPro

public class Result : MonoBehaviour
{
    public TMP_Text[] numberTexts;
    public TMP_Text resultText;
    public int maxRepetitions;

    // Método que cuenta cuántas veces se repite el número que más veces aparece
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

        // Obtener los números de los textos
        for (int i = 0; i < numberTexts.Length; i++)
        {
            // Convertimos el texto del TMP_Text a número entero
            numbers[i] = int.Parse(numberTexts[i].text);
        }

        // Cuenta las veces que aparece cada número
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

        // Encuentra el número con más repeticiones
        maxRepetitions = 0;
        foreach (var pair in numberCount)
        {
            if (pair.Value > maxRepetitions)
            {
                maxRepetitions = pair.Value;
            }
        }

        // Muestra el resultado (cantidad de veces que se repite el número más repetido)
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
