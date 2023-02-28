using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ConoSonoro_RECEIVE : MonoBehaviour
{
    private TMP_Text casellaDiTesto;

    void Start()
    {
        casellaDiTesto = GetComponent<TMP_Text>();
    }

    void Update()
    {

    }

    public void ReceiveValue(float conoSonoro)
    {
        casellaDiTesto.text = System.Math.Round(conoSonoro, 2).ToString();
    }
}
 

 
