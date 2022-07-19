using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
        Debug.Log("Game Development");
        for(int i = 0; i < 12; i++)
        {
            if (i % 2 == 1)
            {
                print(i);
            }
        }
        for(int j = 0; j <= 15; j++)
        {
            if(j % 3 == 0 || j % 5 == 0)
            {
                print(j);
            }
        }
        int[] arr = new int[4] { 0, 1, 2, 3 };
        for (int i = arr.Length-1; i >=0; i--)
        {
            print(arr[i]);
        }
        List<int> yes = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            yes.Add(i*2);
        }
        yes.Remove(12);
        yes.RemoveAt(5);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
