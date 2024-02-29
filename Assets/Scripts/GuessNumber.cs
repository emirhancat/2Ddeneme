using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GuessNumber : MonoBehaviour
{
    
    public int guess;
    public int randomNumber;
    private TextMeshProUGUI textMeshPro;
    
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();     
        textMeshPro.text = "Pick a number between 1 and 10";
        randomNumber = Random.Range(1, 10);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckGuess()
    {
        if (guess > 0 && guess < 11)
        {
            if (guess == randomNumber)
            {
                textMeshPro.text = "Correct! Well done.";            
            }
            else if (guess > randomNumber)
            {
                textMeshPro.text = "Too high!";
            }
            else 
            {
                textMeshPro.text = "Too low!";
            }

        }

        else 
        {
            textMeshPro.text = "Please guess number between 1 and 10";
        }

    }







}
