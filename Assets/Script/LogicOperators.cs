using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicOperators : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // ! Invertes the boolean value 
        print(!true);     //False
        print(!false);    //True
        print(!(6 == 6)); //False
         
        //Asks if ALL statments are true, if either is false the result is false 
        print(true && true);  //True
        print(true && false); //False
        print(false && true); //False 
        print(false && false);//False 

        //Asks if ONE of thes statments is strue, if it is result is true  
        print(true || true);   //True
        print(true || false);  //True
        print(false || true);  //True 
        print(false || false); //False 

               //True     True     False 
        print((6 == 6) && true || (7 < 3)); // True
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
