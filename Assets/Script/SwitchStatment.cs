using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Switch Statement allows you to test the variable against a bunch of diffrent cases
        int variable = 0;
        switch (variable)
        {
            case 1:
                {
                    print("Case 1");
                    //Break Tells us to leave the Switch Statment,
                    //otherwise we will continue to look at all the other statements
                    break;
                }
            case 2:
                {
                    print("Case 2");
                    break;
                }
            case 3: 
                {
                    print("Case 3");
                    break;
                }
            default:
                {
                    print("Case Deafult");
                    break;
                }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
