using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessScript : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetTrigger("Play");
            audioSource.playOnAwake = true;
            audioSource.enabled = true;
            audioSource.Play();
        }
    }
}
