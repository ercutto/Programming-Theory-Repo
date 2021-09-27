using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapes : MonoBehaviour
{
    public float speed { get; private set; } = 1f;//encapsulated
    public float jumpSpeed { get; private set; } = 2f;//encapsulated

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        StartCoroutine(JumpAgain());
    }
    public virtual void Move()//abstration will be owerrited for every object in shapes class
    {

    }
    public virtual void Jump()//abstration will be owerrited for every object in shapes class
    {

    }
    IEnumerator JumpAgain()
    {
        yield return new WaitForSeconds(3);
        Jump();
    }
}
