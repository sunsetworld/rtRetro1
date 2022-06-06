using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Move : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("こんにちは、せかい！");
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 4000 * Time.deltaTime);
    }
}
