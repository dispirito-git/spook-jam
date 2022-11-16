using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPos : MonoBehaviour
{
    private InterObj me;
    // Start is called before the first frame update
    void Start()
    {
        me = new InterObj(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (me.isClicked() && transform.position.x != -1946)
        {
            transform.SetPositionAndRotation(new Vector3(-1946, 528, 0), new Quaternion(0, 0, 0, 0));
        }

    }
}
