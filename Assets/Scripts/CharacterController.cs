using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public new Rigidbody[] rigidbodys;
    public Animator animator;

    private void Awake()
    {
        for (int i = 0; i < rigidbodys.Length; i++)
        {
            rigidbodys[i].isKinematic = true;
        }
    }
}
