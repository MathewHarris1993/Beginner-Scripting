using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NintendoSwitch : MonoBehaviour
{
    public int intelligence = 5;


    void Greet()
    {
        switch (intelligence)
        {
            case 5:
                print("Hello There.");
                break;
            case 4:
                print("General Kenobi");
                break;
            case 3:
                print("Baba boey");
                break;
            case 2:
                print("Roger Roger");
                break;
            case 1:
                print("Ulg, glib, Pblblblblb");
                break;
            default:
                print("404 Error");
                break;
        }
    }
}
