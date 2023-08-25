using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    float zaman = 0;
    public TextMeshProUGUI zamanText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zamanText.text = " Süre: " + (int)zaman;
        if (zaman <= 100000)
        {
            zaman += Time.deltaTime;

        }
    }
}
