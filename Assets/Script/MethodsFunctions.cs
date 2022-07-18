using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodsFunctions : MonoBehaviour
{
    //============================================================================
    // Variables 
    //============================================================================
    int variableOne = 0;
    int variableTwo = 1;
    int variableThree = 2; 


    //============================================================================
    // Base Methods  
    //============================================================================

    // Start is called before the first frame update
    void Start()
    {
        DeafultParametersPrint();
        DeafultParametersPrint("New Text");
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    //============================================================================
    // Custom Methods  
    //============================================================================


    /*
    * Purpose: Prints out the Hello Wolrd Statment 
    * Parameters: N/A
    * Return: N/A
   */
    void DeafultParametersPrint(string text = "Hello Wolrd")
    {
        print(text);
    }


    /*
    * Purpose: Prints out the Hello Wolrd Statment 
    * Parameters: N/A
    * Return: N/A
   */
    void PrintOutStatment()
    {
        print("Hello World");
    }

    /*
     * Purpose: Prints out the statment provided to the Method 
     * Parameters: Statment 
     * Return: N/A
    */
    void PrintOutStatment(string statment)
    {
        print(statment);
    }

    /*
    * Purpose: Returns the square of the provided value 
    * Parameters: Intger Value 
    * Return: The Value Multipled by itself 
    */
    int SquareValue(int value)
    {
        return value * value;
    }
}
