using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyOperator : MonoBehaviour
{

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



    public void DisplayMessage()
    {
        int xp = 990;
        xp += 10;

        int strength = 18;
        ++strength;

        textMeshPro.text = $"{strength}";
    }




}
