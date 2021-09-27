using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : Shapes
{

    public override void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
}
