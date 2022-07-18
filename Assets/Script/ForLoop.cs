using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int variable = 0;
        //For loop allows you to perform something x amount of times 4
        //you create a variable i that's only in the scope of the loop 
        //Once you exit the loop i no longer exits and can be used in a new 
        //loop
        for (int i = 0; i < 4; i++)
        {
            variable += i;
            print(variable);
        }

        //You can use any start, end and increments for the for loop
        for (int i = 8; i > 0; i -= 2)
        {
            variable -= i;
            print(variable);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
