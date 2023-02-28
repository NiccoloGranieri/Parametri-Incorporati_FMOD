using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Direzione_RECEIVE : MonoBehaviour
{
    private TMP_Text casellaDiTesto;

    void Start()
    {
        casellaDiTesto = GetComponent<TMP_Text>();
    }

    void Update()
    {
        
    }

    public void ReceiveValue(float direzione)
    {
        casellaDiTesto.text = System.Math.Round(direzione, 2).ToString();
    }
}
 

 
