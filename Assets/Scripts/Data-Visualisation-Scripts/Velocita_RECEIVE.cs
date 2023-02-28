using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Velocita_RECEIVE : MonoBehaviour
{
    private TMP_Text casellaDiTesto;

    void Start()
    {
        casellaDiTesto = GetComponent<TMP_Text>();
    }

    void Update()
    {
        
    }

    public void ReceiveValue(float velocita)
    {
        casellaDiTesto.text = System.Math.Round(velocita, 2).ToString();
    }
}
 

 
