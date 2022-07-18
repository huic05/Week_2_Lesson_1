using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Lists work very similarly to array with the exception that they have 
        //the power to be expanded or shrunk in their size
        List<int> list = new List<int>();

        //Tells you the Lenght of the list 
        print("Size " + list.Count);

        //Extends the size and adds a the value at the end of the list 
        list.Add(52);
        print("Index 0 " + list[0] + " Size " + list.Count);

        //Extends the size and adds the value at the provided index of the list
        list.Insert(0, 1);
        for (int i = 0; i < list.Count; i++) { print("Index " + i + " " + list[i]); }
        print("Size " + list.Count);

        //Removes the first index that has the same value as pass in value 
        list.Remove(52);
        print("Index 0 " + list[0] + " " + list.Count);

        //Removes the value at the provided index 
        list.RemoveAt(0);
        print("Size " + list.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
