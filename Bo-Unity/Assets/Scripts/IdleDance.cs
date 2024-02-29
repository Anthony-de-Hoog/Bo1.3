using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class IdleDance : MonoBehaviour
{
    Animator m_Animator;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        //Press the up arrow button to reset the trigger and set another one
        if (Input.GetKey(KeyCode.UpArrow))
        {

            //Send the message to the Animator to activate the trigger parameter named "Jump"
            m_Animator.SetTrigger("Dance");
        }

    }

}