using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablingandDisablingComponents : MonoBehaviour
{

    private Light myLight;


    void Start()
    {
        myLight = GetComponent<myLight>();

    }

    
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;

        }
    }
}
