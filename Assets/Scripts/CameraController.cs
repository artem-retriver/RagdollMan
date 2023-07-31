using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform character;
    private Vector3 offset;

    private void Awake()
    {
        offset = transform.position - character.position;
    }

    private void Update()
    {
        Vector3 newPos = new(character.position.x
            + offset.x, character.position.y 
            + offset.y, character.position.z + offset.z);
        transform.position = newPos;
    }
}
