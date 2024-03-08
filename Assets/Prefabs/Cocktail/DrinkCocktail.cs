using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkCocktail : MonoBehaviour
{
    public Animator animator;

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
            Debug.Log("Ping");
            other.BroadcastMessage("EnterFood", this);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Pong");
            other.BroadcastMessage("ExitFood", this);
        }
    }

    public void Eat()
    {
        animator.SetTrigger("DrinkTrigger");
    }
}
