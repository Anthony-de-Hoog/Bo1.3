using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCube : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float m_Thrust = 200f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space key was pressed");
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            //Apply a force to this Rigidbody in direction of this GameObjects up axis
            m_Rigidbody.AddForce(transform.up * m_Thrust);
        }

    }
}
