using System.Collections;
using UnityEngine;

public class Test : MonoBehaviour {

    void Start()
    {
        int[] array = {0, 1, 2, 3, 4};

         for (int i = 0; i < array.Length; i++)
         {
             Debug.Log(array[i]);
         }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
    }
}
