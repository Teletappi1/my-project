using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_testi2 : MonoBehaviour
{


    string testi1 = "Terve";
    string Testi2 = "Haalo";

    float a = 100f;
    float b = 50f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(testi1 == Testi2);
        Debug.Log( "testaus" == "testaus");
        Debug.Log(122 == 123);
        bool result =testi1 != Testi2;
        Debug.Log(result);
        
        Debug.Log(a >b);


        float temperatureInOulu = 2.3f;
        float temperatureInIvalo = 10.9f;
  
if (temperatureInOulu > temperatureInIvalo)
{
    Debug.Log("Oulu is warmer than Ivalo");
}
else if (temperatureInOulu < temperatureInIvalo)
{
    Debug.Log("Ivalo is warmer than Oulu");
}
else
{
    Debug.Log("Oulu and Ivalo have the same temperature");
}


{   
    float temperatureInSauna = 60f;


     if (60f > temperatureInSauna && temperatureInSauna < 80f)

    Debug.Log("Saunassako me ollaan");

    string message = (60f < temperatureInSauna && temperatureInSauna < 80f)
        ?  "saunassako me ollaan"
        : "ei vissiin olla saunassa";
        Debug.Log(message);

            


    }


        



        
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
} 
