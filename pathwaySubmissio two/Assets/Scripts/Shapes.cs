using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapes : MonoBehaviour
{
    public virtual float maxDistance { get; set; } = 20f;
    public float speed = 1f;
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public float jumpSpeed = 1f;
    public void Awake()
    {
        if (jumpSpeed<0)
        {
            Debug.LogError("Jump speed cant be less than 0");
        }
        
    }
    void Start()
    {
        
    }
    public  void Update()
    {
     
        if (transform.position.z > maxDistance)
        {
            speed = -1;
        }
        else if (transform.position.z < -maxDistance)
        {
            speed = 1;
        }
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
        Jump();
        yield return new WaitForSeconds(5);
        Move();
    }
}
