using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator animator;
    public IndoorSound indoorSound;
    public OutdoorSound outdoorSound;

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
            animator.SetBool("Open", true);
            indoorSound.open = true;
            outdoorSound.open = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Open", false);
            indoorSound.open = false;
            outdoorSound.open = false;
        }
    }
}
