using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Distanza_RECEIVE : MonoBehaviour
{
    private TMP_Text casellaDiTesto;

    void Start()
    {
        casellaDiTesto = GetComponent<TMP_Text>();
    }

    void Update()
    {

    }

    public void ReceiveValue(float distanza)
    {
        casellaDiTesto.text = System.Math.Round(distanza, 2).ToString();
    }
}
 

 
