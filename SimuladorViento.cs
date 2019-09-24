using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimuladorViento : MonoBehaviour
{
    Rigidbody mRigidbody;
    void Start()
    {
        mRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "Pluma") mRigidbody.drag = 10;
        if (tag == "Ladrillo") mRigidbody.drag = 0;
        if (tag =="Papel") mRigidbody.drag = 5;

    }
}
