using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      int y=5;
     
      for (int z=1; z<11; z++)
      {
        int result= Multiply(z,y);
        int equ1 = Equation1(z);
        int equ2 = Equation2(y);
        Debug.Log(equ1+"x"+equ2+"="+result);
      } 
    }

    int Multiply (int z, int y)
     {
       int Multiplication =z*y;
       return Multiplication; 
     }
    int Equation1 (int z)
     {
       int equation1 = z;
       return equation1; 
     }
      int Equation2 ( int y)
     {
       int equation2 = y;
       return equation2; 
     }
    // Update is called once per frame
    void Update()
    {
        
    }
}
