using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private GameObject currentGameObject;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentGameObject != null)
        {
            transform.position = currentGameObject.GetComponent<Teleporter>().GetDestination().position;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Teleporter"))
        {
            currentGameObject = col.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Teleporter"))
        {
            if (other.gameObject == currentGameObject)
            {
                currentGameObject = null;
            }
        }
    }
}
