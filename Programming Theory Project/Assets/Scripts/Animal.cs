using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class Animal : MonoBehaviour
{
    private int legs;
    private float speed;
    private float forceJump;

    private Rigidbody rb;

    // ENCAPSULATION
    public int Legs
    {
        get { return legs; }
        set
        {
            if (value > 0)
            {
                legs = value;
            }
        }
    }

    // ENCAPSULATION
    public float Speed
    {
        get { return speed; }
        set
        {
            if (value > 0)
            {
                speed = value;
            }
        }
    }

    // ENCAPSULATION
    public float ForceJump
    {
        get { return forceJump; }
        set
        {
            if (value > 0)
            {
                forceJump = value;
            }
        }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Space) && transform.position.y == 0)
        {
            // ABSTRACTION
            Jump();
        }

        if ((Input.GetKey(KeyCode.UpArrow)) && transform.position.y == 0)
        {
            // ABSTRACTION
            Jump(true);
        }

        if (Input.GetKey(KeyCode.W) && transform.position.y == 0)
        {
            // ABSTRACTION
            Jump(5.0f);
        }
    }

    //POLYMORPHISM
    public void Jump()
    {
        rb.AddForce(0f, forceJump * Time.deltaTime, 0f);
    }

    //POLYMORPHISM
    public void Jump(bool jumpForward)
    {
        if (jumpForward)
        {
            rb.AddForce(0f, forceJump * Time.deltaTime, speed);
        }
        else
        {
            Jump();
        }
        
    }

    //POLYMORPHISM
    public void Jump(float height)
    {
        rb.AddForce(Vector3.up * Mathf.Sqrt(2 * -Physics.gravity.y * height), ForceMode.Impulse);
    }

    //POLYMORPHISM
    public virtual string Talk()
    {
        return string.Empty;
    }
}
