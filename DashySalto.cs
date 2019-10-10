using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DashScript : MonoBehaviour
{
    [SerializeField] float cooldown = 3,force =500;
    float t = 0;
    Rigidbody mCuerpo;
    bool dash = false;
    bool jump = false;

    void Start()
    {
        mCuerpo = GetComponent<Rigidbody>();
        t = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        float magFuerza = 500;
        float sen = 1;
        Vector3 dir = transform.forward*0.7f + transform.up*0.3f;
        Vector3 fuerza = magFuerza * dir * sen;

        if (Input.GetButtonDown("Jump")&& t >= cooldown)
        {
            mCuerpo.AddForce(fuerza);
            t = 0;
            dash = true;
        }
        if (dash && t >= 0.35)
        {
            mCuerpo.velocity=Vector3.zero;
        }
       
    }
    private void OnCollisionStay(Collision piso)
    {
        jump = true;
        GameObject colision = piso.gameObject;
        Rigidbody colisionCuerpo = colision.GetComponent<Rigidbody>();

        if (Input.GetButtonDown("Fire2") && jump == true)
        {
            Vector3 dire = transform.up * 0.7f;
            mCuerpo.AddForce(dire * force);
        }

    }


}
