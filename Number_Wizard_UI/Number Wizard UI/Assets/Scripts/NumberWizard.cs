using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;


    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }


    void StartGame()
    {
        NextGuess();
    }    

    public void OnPressHigher()
    {
        min = guess + 1;
        if (min > max) min = max;
        NextGuess();
    }


    public void OnPressLower()
    {
        max = guess - 1;
        if (max < min) max = min;
        NextGuess();
    }

    public void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }


}
