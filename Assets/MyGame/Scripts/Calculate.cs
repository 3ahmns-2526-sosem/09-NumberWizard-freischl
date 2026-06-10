using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Calculate : MonoBehaviour
{
    [SerializeField] private int min;
    [SerializeField] private int max;

    private int guess;

    [SerializeField] private TextMeshProUGUI guessText;

    public Button higherButton;
    public Button lowerButton;
    public Button correctButton;

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
    public void OnCorrectPressed()
    {
        guessText.text = "I guessed your Numberrrrr!";

        higherButton.interactable = false;
        lowerButton.interactable = false;
        correctButton.interactable = false;
    }
}