using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocita_SEND : MonoBehaviour
{
    float absoluteSpeed;
    float relativeSpeed;
    Rigidbody m_Rigidbody;
    Rigidbody s_Rigidbody;

    private FMOD.Studio.EventInstance instance;
    private FMOD.Studio.EventInstance instance2;

    private GameObject player;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        instance = FMODUnity.RuntimeManager.CreateInstance("event:/Velocita");
        // instance2 = FMODUnity.RuntimeManager.CreateInstance("event:/Velocita_R");
        instance.start();
        // instance2.start();
        player = GameObject.Find("PlayerArmature");
        s_Rigidbody = player.GetComponent<Rigidbody>();


    }

    void Update()
    {
        instance.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject, m_Rigidbody));
        // instance2.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject.transform, m_Rigidbody));
        instance.getParameterByName("Speed", out _, out absoluteSpeed);
        // instance2.getParameterByName("Speed_R", out _, out relativeSpeed);

        // Debug.Log($"Relative Speed: {relativeSpeed}");

        FindObjectOfType<Velocita_RECEIVE>().ReceiveValue(absoluteSpeed);
        // FindObjectOfType<Velocita_R_RECEIVE>().ReceiveValue(relativeSpeed);
    }
}