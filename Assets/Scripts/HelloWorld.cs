using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HelloWorld : MonoBehaviour
{
    public string firstName;
    private TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"Hello {firstName}!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
