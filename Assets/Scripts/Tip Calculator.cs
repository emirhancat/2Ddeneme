using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TipCalculator : MonoBehaviour
{

    public int amount = 0;
    public float percentage = .2F;

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

    public void calculateTip()
    {

    float tipAmount = (float) amount * percentage;
    int totalAmount = (int) tipAmount + amount;
        textMeshPro.text = $"{totalAmount}";


    }
}