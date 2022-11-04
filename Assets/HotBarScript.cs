using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotBarScript : MonoBehaviour
{
    [SerializeField] public Dictionary<string, int> items;
    // Start is called before the first frame update
    void Start()
    {
        items = new Dictionary<string, int>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
