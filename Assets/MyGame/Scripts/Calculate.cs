using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
public class Calculate : MonoBehaviour
{
    // Variablen wurden angegeben 
    [SerializeField] private int min;
    [SerializeField] private int max;
    private int guess;
    [SerializeField] private TextMeshProUGUI guessText;
    public Button higherButton;
    public Button lowerButton;
    public Button correctButton;

    private void Start()
    {
        // Funktion wird direkt beim Start ausgeführt
        CalculateFirstGuess();
    }
    private void CalculateFirstGuess()
    {
        //Guesses werden bearbeitet
        guess = (min + max) / 2;
        UpdateUI();
    }
    private void UpdateUI()
    {
        // Überarbeitet die Guessvariable
        if (guessText != null)
        {
            guessText.text = "Guess: " + guess;
        }
    }
    public void OnHigherPressed()
    {
        // Funktion für den Higher Button
        min = guess + 1;
        CalculateFirstGuess();
    }
    public void OnLowerPressed()
    {
        // Funktion für den Lower Button
        max = guess - 1;
        CalculateFirstGuess();
    }
    public void OnCorrectPressed()
    {
        // Funktion für den Correct Button
        guessText.text = "I guessed your Numberrrrr!";
        higherButton.interactable = false;
        lowerButton.interactable = false;
        correctButton.interactable = false;
    }
    private IEnumerator TimerForRestart()
    {
        // Restartet das Game nach bestimmter Zeit
        yield return new WaitForSeconds(5);
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        SceneManager.LoadScene(0);
    }
}