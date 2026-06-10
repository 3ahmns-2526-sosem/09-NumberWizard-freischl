using TMPro;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    [SerializeField] private int min;
    [SerializeField] private int max;

    private int guess;

    [SerializeField] private TextMeshProUGUI guessText;
    void Start()
    {
        CalculateFirstGuess();
    }
    void CalculateFirstGuess()
    {
        guess = (min + max) / 2;
        UpdateUI();
    }
    void UpdateUI()
    {
        if (guessText != null)
        {
            guessText.text = "Guess: " + guess;
        }
    }
    public void OnHigherPressed()
    {
        min = guess + 1;
        CalculateFirstGuess();
    }
    public void OnLowerPressed()
    {
        max = guess - 1;
        CalculateFirstGuess();
    }
}