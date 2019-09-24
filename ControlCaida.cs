using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCaida : MonoBehaviour
{
    Rigidbody mRigidbody;
    Renderer mRender;

    void Start()
    {
        mRender = GetComponent<Renderer>();
        mRigidbody = GetComponent<Rigidbody>();

    }

    void Update()
    {
        Color c = new Color(1, 0, 0);
     
        if ( mRigidbody.velocity.y < - 7){
            mRender.material.color = c;

        }
    }
}
