using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;

    }

    void TemperatureTest ()
    {
        //If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this
            print("Coffee is too hot!");

        }

        // If it isnt to hot, but it is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            //... do this
            print("Coffee is too cold");

        }
        // if neither
        else
        {
            // do this
            print("Coffee is just right.");

        }
    }
}
