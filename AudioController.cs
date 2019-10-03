using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] float magnitud = 8;
    [SerializeField] float magnitudA = 90;
    [SerializeField] AudioClip AudioIdle;
    [SerializeField] AudioClip AudioMove;
    AudioSource mAudioSource;

    void Start()
    {
        mAudioSource = GetComponent<AudioSource>();
    }


    void Update()
    {

        
        Vector3 direccionV = transform.forward;
        Vector3 direccionH = new Vector3(0, 1, 0);


        float sentidoV = Input.GetAxis("Vertical");
        float sentidoH = Input.GetAxis("Horizontal");

        Vector3 velocidadV = magnitud * direccionV * sentidoV;
        Vector3 distanciaV = velocidadV * Time.deltaTime;
        transform.position += distanciaV;

        Vector3 velocidadH = magnitudA * direccionH * sentidoH;
        Vector3 distanciaH = velocidadH * Time.deltaTime;
        transform.eulerAngles = transform.eulerAngles + distanciaH;


        if (Input.GetButton("Vertical") || Input.GetButton("Horizontal") || Input.GetButton("Jump")) 
        {
            
            mAudioSource.clip = AudioMove;
            if (!mAudioSource.isPlaying) mAudioSource.Play();

        }
        else
        {

            if (!mAudioSource.isPlaying) mAudioSource.Play();

            mAudioSource.clip = AudioIdle;

            
        }


         
    }
}
