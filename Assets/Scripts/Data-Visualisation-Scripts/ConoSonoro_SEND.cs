using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConoSonoro_SEND : MonoBehaviour
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
        eventInst.getParameterByName("Event Cone Angle", out _, out finalParameterValue);

        FindObjectOfType<ConoSonoro_RECEIVE>().ReceiveValue(finalParameterValue);
    }
}



 
