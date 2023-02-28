using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distanza_SEND : MonoBehaviour
{
    float finalParameterValue;
    public FMODUnity.EventReference eventRef;
    FMOD.Studio.EventInstance eventInst;

    void Start()
    {
        eventInst = FMODUnity.RuntimeManager.CreateInstance(eventRef);
    }

    void Update()
    {
        eventInst.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
        eventInst.start();
        eventInst.release();
        eventInst.getParameterByName("Distance", out _, out finalParameterValue);

        FindObjectOfType<Distanza_RECEIVE>().ReceiveValue(finalParameterValue);
    }
}



 
