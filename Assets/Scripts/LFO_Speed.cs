using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LFO_Speed : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Speed = 5f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 m_Input = new Vector3(1, 0, 0);
        m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);
    }
}
