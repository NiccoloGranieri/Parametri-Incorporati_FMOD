using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DistanzaNorm_RECEIVE : MonoBehaviour
{
    private TMP_Text casellaDiTesto;

    void Start()
    {
        casellaDiTesto = GetComponent<TMP_Text>();
    }

    void Update()
    {

    }

    public void ReceiveValue(float distanzaNorm)
    {
        casellaDiTesto.text = System.Math.Round(distanzaNorm, 2).ToString();
    }
}
 

 
