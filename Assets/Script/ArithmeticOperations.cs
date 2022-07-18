using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArithmeticOperations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int variableOne = 0;
        int variableTwo = 5;

        //Sometimes you want to change the value of a variable by itself and some other variable
        variableOne = variableOne + variableTwo;
        print(variableOne);

        //To do this there is a shorthand that simplifies the code, changing variableOne + to +=, -=, *= and /=
        variableOne += variableTwo;
        print(variableOne);

        variableOne -= variableTwo;
        print(variableOne);

        variableOne *= variableTwo;
        print(variableOne);

        variableOne /= variableTwo;
        print(variableOne);

        //A lot of times you will want to increase/decrease a number by one for counting purpose
        variableOne = variableOne + 1;
        print(variableOne);

        //For that the ++ or -- is shorthand for increase/decrease by one 
        variableOne++;
        print(variableOne);

        variableOne--;
        print(variableOne);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
