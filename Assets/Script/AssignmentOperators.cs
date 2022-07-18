using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignmentOperators : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int variableOne;
        int variableTwo = 5;

        //Adds the value of variableTwo and 5 and assigns the value to variableOne 
        variableOne = variableTwo + 5;
        print(variableOne);

        //Subtracts the value of variableTwo and 5 and assigns the value to variableOne 
        variableOne = variableTwo - 5;
        print(variableOne);

        //Multiplies the value of variableTwo and 5 and assigns the value to variableOne 
        variableOne = variableTwo * 5;
        print(variableOne);

        //Divdes the value of variableTwo and 5 and assigns the value to variableOne 
        variableOne = variableTwo / 5;
        print(variableOne);

        //Modules the value of variable Two over 5, module asks how many times does the second number fits into the first and what is the remider.
        //Here the result is 0 as 5 fits into 5, one time without leaving 0 as reminder. Think of it as 5/5 which is 1 0/5. 
        variableOne = variableTwo % 5;
        print(variableOne);

        //Here the result is 1 as 2 fits into 5, two times leaving 1 as remidner. Think of it as 5/2 which is 2 1/2.
        variableOne = variableTwo % 2;
        print(variableOne);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
