using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixPos : MonoBehaviour
{
    private InterObj me;
    public Vector3 pos;
    public Quaternion rot;
    // Start is called before the first frame update
    void Start()
    {
        me = new InterObj(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (me.isClicked() && transform.rotation.z != rot.z)
        {
            transform.SetPositionAndRotation(pos, rot);
        }

    }
}
