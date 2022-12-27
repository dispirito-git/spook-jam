using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

public class PlayerTeleport : MonoBehaviour
{

    public AudioClip door, paper;
    private GameObject currentGameObject;

    private Random rand = new Random();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentGameObject != null)
        {
            transform.position = currentGameObject.GetComponent<Teleporter>().GetDestination().position;
            GetComponent<AudioSource>().pitch = ((float)(rand.NextDouble() * 0.2f) + 0.9f);
            GetComponent<AudioSource>().PlayOneShot(door);
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
