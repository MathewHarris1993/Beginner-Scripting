using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketGoBoom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1.5f);
    }

    }
