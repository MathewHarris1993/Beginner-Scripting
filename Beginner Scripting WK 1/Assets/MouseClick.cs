using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private RigitBody rb;

    private void Awake ()
    {
        rb = GetComponent<RigidBody>();

    }

    void OnMouseDown ()
    {
        rb.AddForce(-transform.forward * 500f);
        rb.useGravity = true;

    }


}
