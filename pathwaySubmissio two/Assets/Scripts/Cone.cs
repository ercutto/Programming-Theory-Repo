using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cone : Shapes//inheritance
{
   


    public override void Move()//Abstracted
    {                                          //InheritSpeed
        transform.Translate(Vector3.forward *speed * Time.deltaTime);
    }
    public override void Jump()//Abstracted
    {                                        //InheritjumpSpeed
        transform.Translate(Vector3.up *jumpSpeed * Time.deltaTime);
    }
}
