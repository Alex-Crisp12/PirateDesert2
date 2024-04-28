using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
	public CharacterController characterController;
	public Transform transform;
	
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
			characterController.enabled = false;
			transform.position = new Vector3(5.0f, 0, -24.0f);
			characterController.enabled = true;
		}
	}
}
