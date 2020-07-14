using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] private int max = 1000;
    [SerializeField] private int min = 1;    
    [SerializeField] private TextMeshProUGUI guessText;

    private int guess;

    // Use this for initialization
    private void Start()
    {        
        NextGuess();
        max += 1;
    }

    public void OnPressHigher()
    {
        min = guess + 1 < max - 1 ? guess + 1 : max - 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }
    
    private void NextGuess()
    {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max);
        if (max < 1)
            max = 1;
        guessText.text = guess.ToString();
    }
}
