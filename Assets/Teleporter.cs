using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] private Transform destination;

    public Transform GetDestination()
    {
        return destination;
    }
    
}
