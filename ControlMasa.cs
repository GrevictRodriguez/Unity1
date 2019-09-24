using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMasa : MonoBehaviour
{

    Rigidbody mRigidbody;
    Renderer mRender;

    void Start()
    {
        
        mRigidbody = GetComponent<Rigidbody>();
        mRender = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(1, 0, 0);
        if (mRigidbody.mass > 5)
        {
            mRender.material.color = c;
        }

    }
}
