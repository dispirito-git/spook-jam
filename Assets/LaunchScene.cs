using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Scripts;

public class LaunchScene : MonoBehaviour
{
    private InterObj me;
    public int which;
    // Start is called before the first frame update
    void Start()
    {
        me = new InterObj(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (me.isClicked())
        {
            SwitchScene();
        }
        
    }
    public void SwitchScene()
    {
        SceneManager.LoadSceneAsync(3);
        SceneManager.LoadSceneAsync(which);
    }
    
}
