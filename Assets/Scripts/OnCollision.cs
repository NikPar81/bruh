using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OnCollision : MonoBehaviour
{
    void OnCollisionExit (Collision other)
    {
        print(other.gameObject.name);
        Console.WriteLine("2");
    }
   
   
}
