using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Array holds a preset number of variables declared by the [4]
        //with the variables specified in the {0, 1, 2, 3}
        int[] array = new int[4] { 0, 1, 2, 3 };

        //The positions in an array start at 0 and increment by 1
        print(array[0]);

        //Array has a lenght component that can be assested by the . 
        print(array.Length);

        //For Loop is great for accessing each variable in the array,
        //the end size is array.Length - 1 as we start at 0 and end at 3.
        for (int i = 0; i < array.Length - 1; i++)
        {
            print(array[i]);
        }

        //Foreach loop allows you to go through every variabe in the array
        foreach(int variable in array)
        {
            print(variable);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
