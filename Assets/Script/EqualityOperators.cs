using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatments: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Checks if the two sides are equal 
        print(6 == 7); //False
        print(6 == 6); //True

        //Checks if the two side are not equal 
        print(6 != 7); //True
        print(6 != 6); //False 

        //Checks if one side is large than the other 
        print(5 > 3); //True
        print(5 < 3); //False 
        print(3 > 3); //Fasle 

        print(5 >= 3); //True 
        print(5 <= 3); //False
        print(3 >= 3); //True
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
