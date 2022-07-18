using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int counter = 0;
        //While loop executes until the statement is true,
        //It is possible to make a statement that will not be
        //fulfilled and create an infinite loop that will never finish executing
        while (counter < 100)
        {
            counter++;
            print(counter);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
