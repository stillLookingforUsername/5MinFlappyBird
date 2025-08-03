using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [Range(1f,20f)] public float speed = 1f;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
