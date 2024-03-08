using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Devourer : MonoBehaviour
{
    private GameObject[] consumed = {};
    private int no_consumed = 0;
    private GameObject[] consumables = {};
    private int no_consumables = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (no_consumables != 0)
            {
                no_consumables--;
                consumables[no_consumables].BroadcastMessage("Eat");
                consumed[no_consumed] = consumables[no_consumables];
                no_consumed++;
                consumables[no_consumables] = null;
            }
        }
    }

    public void EnterFood(GameObject other)
    {
        if (!consumed.Contains(other) && !consumables.Contains(other))
        {
            consumables[no_consumables] = other;
            no_consumables++;
            Debug.Log("Adding item to list");
        }
    }

    public void ExitFood(GameObject other)
    {
        for (int index = 0; index != no_consumables; index ++)
        {
            if (consumables[index] == other)
            {
                Debug.Log("Removing item from list");
                for (int index2 = index; index2 != no_consumables - 1; index2++)
                {
                    consumables[index2] = consumables[index2 + 1];
                }
                no_consumables--;
                consumables[no_consumables] = null;
                break;
            }
        }
    }
}
