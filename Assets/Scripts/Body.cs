using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : CharacterController
{
    public new CameraController camera;
    public CharacterController characterController;
    new Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        for (int i = 0; i < rigidbodys.Length; i++)
        {
            rigidbodys[i].isKinematic = false;
        }

        camera.enabled = true;
        animator.enabled = false;
        rigidbody.useGravity = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Cube>())
        {
            for (int i = 0; i < rigidbodys.Length; i++)
            {
                rigidbodys[i].isKinematic = true;
            }

            characterController.gameObject.transform.position = camera.character.position;
            animator.enabled = true;
            animator.Play("Getting Up");
            Debug.Log("1");
        }
    }
}
