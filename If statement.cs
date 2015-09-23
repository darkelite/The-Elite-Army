using UnityEngine;
using System.Collections;
using System; 

public class Ifstatement : MonoBehaviour

{

   
    // Use this for initialization
        float Heightrange = 25.0f;
        float Heightrangemaxalt = 30.0f;
        float Heightrangeminimum = 15.0f;

    

    // Update is called once per frame
    void Update()

    {

        if (Input.GetKeyDown(KeyCode.Space))
            HeightrangeTest();

     Heightrange -= Time.deltaTime * 5f;
    }

    void HeightrangeTest()
    {
        if (Heightrange > Heightrangemaxalt)

        {
            // ... do this
            print("Height is to high");
        }
        else if (Heightrange < Heightrangeminimum)
        {
            print("height is lower");
        }
        else
        { print("height is in target");

        }
    }
} 