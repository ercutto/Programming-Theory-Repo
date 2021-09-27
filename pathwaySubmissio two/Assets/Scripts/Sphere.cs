using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shapes
{


    public override void Move()
    {
        transform.Translate(Vector3.forward*speed * Time.deltaTime);
    }
    public override void Jump()
    {
        transform.Translate(Vector3.up * jumpSpeed * Time.deltaTime);
    }
}
