using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqualityOperators : MonoBehaviour
{

    int Integer = 1;
    float Float = 1.23456789012345678901234567890f;
    double Double = 1.23456789012345678901234567890d;
    bool Boolean = true;
    char Character = 'a';
    string String = "Hello World";

    int variableOne = 4;


    // Start is called before the first frame update
    void Start()
    {
        int variableTwo = variableOne + 5;
        print(variableTwo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
