using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorAudio : MonoBehaviour
{
    // Start is called before the first frame update


    AudioSource mAudio;
    float t = 0;
    void Start()
    {
        mAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t >= 5)
        {
            mAudio.volume = 0;
        }
    }
}
