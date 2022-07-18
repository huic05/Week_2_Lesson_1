using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{
    //Enum allows you to create named constants that are easier
    //for the programer to keep track of states in a more undesable
    //way that using integer to define states
    enum State
    {
        Load,
        Playing,
        Die
    }

    //Enum create a new variable type that you can now acess
    State currentState = State.Load;

    // Start is called before the first frame update
    void Start()
    {
        switch (currentState)
        {
            case State.Load:
            {
                //Do Something
                break;
            }
            case State.Playing:
            {
                 //Do Something
                 break;
            }
            case State.Die:
            {
                 //Do Something
                 break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
