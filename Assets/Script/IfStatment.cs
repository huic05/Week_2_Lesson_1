using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int variable = 0;
        //Asks if a statement true, if is execute code inside the braces otherwise moves on
        if (variable == 0)
        {
            print("Statment One: If");
        }

        //Asks if a statement true, if is execute code inside the brace otherwise moves on 
        //Else execute the code in else braces
        if (variable == 6) 
        {
            print("Statment Two: If");
        }
        else
        {
            print("Statment Two: Else");
        }

        //Checks if any of the statements are true, the first true statement gets executed.
        if (variable == 6)
        {
            print("Statment Three: If");
        }
        else if (variable <= 6)
        {
            print("Statment Three: Else If One");
        }
        else if(variable < 6)
        {
            print("Statment Three: Else If Two");
        }
        else
        {
            print("Statment Three: Else");
        }

        //Assign variable the value of either 10 or -10 depending on if variable is 10 < 0.
        variable = variable < 0 ?  10 : -10;
        print(variable);

    }

    // Update is called once per frame
    void Update()
    {
    }
}
