using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Elevazione_RECEIVE : MonoBehaviour
{
    private TMP_Text casellaDiTesto;

    void Start()
    {
        casellaDiTesto = GetComponent<TMP_Text>();
    }

    void Update()
    {
        
    }

    public void ReceiveValue(float elevazione)
    {
        casellaDiTesto.text = System.Math.Round(elevazione, 2).ToString();
    }
}
 

 
