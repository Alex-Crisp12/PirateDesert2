using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndoorSound : MonoBehaviour
{
    public AudioSource audioSource;
    private bool inside = false;
    public bool open = false;
    public OutdoorSound outdoorSound;

    // Start is called before the first frame update
    void Start()
    {
        inside = false;
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inside | open)
            audioSource.enabled = true;
        else
            audioSource.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inside = true;
            outdoorSound.outside = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inside = false;
            outdoorSound.outside = true;
        }
    }
}
