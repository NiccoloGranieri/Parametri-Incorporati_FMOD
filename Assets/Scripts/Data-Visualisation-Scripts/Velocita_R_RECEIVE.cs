using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Velocita_R_RECEIVE : MonoBehaviour
{
    private TMP_Text casellaDiTesto;

    void Start()
    {
        casellaDiTesto = GetComponent<TMP_Text>();
    }

    void Update()
    {
        
    }

    public void ReceiveValue(float velocitar)
    {
        casellaDiTesto.text = System.Math.Round(velocitar, 2).ToString();
    }
}
 

 
