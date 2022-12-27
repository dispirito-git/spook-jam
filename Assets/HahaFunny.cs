using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HahaFunny : MonoBehaviour
{
    //private InterObj me;
    // Start is called before the first frame update
    void Start()
    {
       // me = new InterObj(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
