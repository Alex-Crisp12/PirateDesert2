using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class OutdoorSound : MonoBehaviour
{
    public AudioSource audioSource;
    public bool outside = true;
    public bool open = false;
    private float volume = 1.0f;
    public float max_volume = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        outside = true;
        open = false;
        volume = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (outside | open)
        {
            if (volume != 1.0f)
            {
                volume += Time.deltaTime;
                if (volume >= 1.0f)
                {
                    volume = 1.0f;
                    audioSource.volume = max_volume;
                }
                else
                    audioSource.volume = volume * max_volume;
            }
        }
        else
        {
            if (volume != 0.0f)
            {
                volume -= Time.deltaTime;
                if (volume <= 0.0f)
                {
                    volume = 0.0f;
                }
                else
                    audioSource.volume = volume * max_volume;
            }
        }
    }
}
