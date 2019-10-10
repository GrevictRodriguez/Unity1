using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Construcciones : MonoBehaviour
{
    [SerializeField] float vida = 100;
    float puntajePerdida =10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vida <= 0) Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision shell)
    {
        vida -= puntajePerdida/2;
    }
}
