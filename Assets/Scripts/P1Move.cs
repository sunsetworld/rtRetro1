using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Move : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 4000;
    public float SidewaysForce = 500;

    bool MoveLeft = false;
    bool MoveRight = false;
    bool MoveForward = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("こんにちは、せかい！");
    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            MoveForward = true;
        }
        else
        {
            MoveForward = false;
        }

        if (Input.GetKey("d"))
        {
            MoveRight = true;
        }
        else
        {
            MoveRight= false;
        }

        if (Input.GetKey("a"))
        {
            MoveLeft = true;
        }
        else
        {
            MoveLeft = false;
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (MoveForward)
        {
            rb.AddForce(0, 0, ForwardForce * Time.deltaTime); // Moves player forward at full speed.
        }
        else
        {        
            rb.AddForce(0, 0, ForwardForce / 2 * Time.deltaTime); // Moves player forward at half speed.
        }

        if (MoveRight)
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0);
        }
        if (MoveLeft)
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0);
        }

    }


}
