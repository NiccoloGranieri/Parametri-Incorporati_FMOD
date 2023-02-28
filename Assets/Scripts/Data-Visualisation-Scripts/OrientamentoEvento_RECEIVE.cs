using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class OrientamentoEvento_RECEIVE : MonoBehaviour
{
    private TMP_Text casellaDiTesto;

    void Start()
    {
        casellaDiTesto = GetComponent<TMP_Text>();
    }

    void Update()
    {
        
    }

    public void ReceiveValue(float orientamentoEvento)
    {
        casellaDiTesto.text = System.Math.Round(orientamentoEvento, 2).ToString();
    }
}
 

 
