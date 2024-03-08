using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum MovementAxis
{
    Down,
    Up   
}







public class Enumeration : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    public MovementAxis playerDirection;

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
        if(playerDirection == MovementAxis.Up)
        {
            textMeshPro.text = $"Player is mowing: 1";
        }
        else 
        {
            textMeshPro.text = $"Player is mowing: -1";
        }

    }    
}
