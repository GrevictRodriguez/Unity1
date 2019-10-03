using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour
{
    Rigidbody mCuerpo;
    void Start()
    {
        mCuerpo = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float magFuerza = 500;
        float sen = 1;
        Vector3 dir = transform.forward;
        Vector3 fuerza = magFuerza * dir * sen;

        if (Input.GetButtonDown("Jump"))
        {
            mCuerpo.AddForce(fuerza);
        }

    }
}
