using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFrecuencia: MonoBehaviour
{

    Light mLuz;
    AudioSource mAudio;
    
    void Start()
    {
        mLuz = GetComponent<Light>();
        mAudio = GetComponent<AudioSource>();
       

    }

    void Update()
    {
        if (mLuz.intensity < 0.5f)
        {
            mAudio.pitch =0.5f;
        }
    }
}
