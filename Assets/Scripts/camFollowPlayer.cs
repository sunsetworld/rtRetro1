using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset3;

    public int toggleNum = 3;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeToggleNum();
        ToggleView();
    }

    void ChangeToggleNum()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            toggleNum = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            toggleNum = 3;

        }
    }

    public void ToggleView()
    {
        if (toggleNum == 1)
        {
            transform.position = player.position;

        }
        else if (toggleNum == 3)
        {
            transform.position = player.position + offset3;
        }
    }

}
