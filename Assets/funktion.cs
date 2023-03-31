using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funktion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    
    Debug.Log("testi start");
    int  a = 0;

    if (a < 10)
    {
    }
    Printname("Matti");
    Printname("Teppo");

    Debug.Log(GenerateBandName("Matti"));
    Debug.Log(GenerateBandName("Teppo"));

    string BandName = GenerateBandName("pasi");
    Debug.Log(BandName);

string Firstname = "Matteus";

Debug.Log(GenerateBetterBandName(
        FirstName,
        "markus",
        "Luukas"
    ));

        Debug.Log(Hypotenuse(3f, 4f));
    }

void Printname(string name)
{
        Debug.Log($"My Name Is {name}");
}
string GenerateBandName(string name)
{
    return $"{name} ja teppo";

}
    string GenerateBandName(
        string name1,
        string name2,
        string name3
        )
    {
        return $"{name1}, {name2}, {name3} ja Pasi";
    }

    // function overload:
    string GenerateBetterBandName(
        string name1,
        string name2,
        int number
        )
    {
        return $"{name1}, {name2}, {number} ja Pasi";
    }

    public static float hypotenuse(float a, float b)
    {
        float c = Mathf.Sqrt(Mathf.Pow(2,a) + Mathf.Pow(b,2));
        return c;
    }

    float Shorterhypotenuse(float a, float b)
    {
        return Mathf.Sqrt(Mathf.Pow(a,2) + Mathf.Pow(b,2));
    }
    

    // Update is called once per frame
    void Update()
    {
        PrintName("Matti");

    }
}
