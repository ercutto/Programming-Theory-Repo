using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prisma : Shapes
{
    public override void Move()//polymorphism
    {
        transform.Translate(Vector3.forward * 10f * speed * Time.deltaTime);
    }
    public override void Jump()//polymorphism
    {
        transform.Translate(Vector3.up * 5f * speed * Time.deltaTime);
    }
}
