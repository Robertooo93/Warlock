using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(CharacterController))]
public class MoveAround : MonoBehaviour
{

    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        //Rotate
        float rrr = CrossPlatformInputManager.GetAxis("Horizontal");
        Debug.Log("Horizontal: " + rrr);
        if (rrr > 0)
        {
            //rrr = 1;
            Debug.Log("Left");
        }
        else if (rrr < 0)
        {
            //rrr = -1;
            Debug.Log("Right");
        }
        transform.Rotate(0, rrr * rotateSpeed, 0);



        //Move forward or backward
        Vector3 forward = transform.TransformDirection(Vector3.forward);

        float fff = CrossPlatformInputManager.GetAxis("Vertical");
        Debug.Log("Vertical: " + fff);
        if (fff > 0)
        {
            fff = 1;
            Debug.Log("Forward");
        }
        else if (fff < 0)
        {
            fff = -1;
            Debug.Log("Backward");
        }

        float curSpeed = speed * fff;
        controller.SimpleMove(forward * curSpeed);
    }

}
