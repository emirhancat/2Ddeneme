using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class My : MonoBehaviour
{
    public int currentPlayer;
    public string message;
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMessage()
    {
        
        string player = (currentPlayer == 1) ? "Player One" : "Player Two";
        textMeshPro.text = $"Ready {player}";

        
    }



}
