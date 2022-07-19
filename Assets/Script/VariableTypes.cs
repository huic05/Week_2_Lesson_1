using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTypes : MonoBehaviour
{

    int Integer = 1;
    float Float = 1.23456789012345678901234567890f;
    double Double = 1.23456789012345678901234567890d;
    bool Boolean = true;
    char Character = 'a';
    string String = "Hello World";

    public int variableOne = 4;
    int variableTwo = 5;
    int variableThree = 6;
   


    // Start is called before the first frame update
    void Start()
    {
        int variableTwo = variableOne + 5;
        print(variableTwo);
        print(variableOne + variableTwo);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
