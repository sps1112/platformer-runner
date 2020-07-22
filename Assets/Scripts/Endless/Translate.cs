using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    public Vector3 motionDirection;

    public float speed;

    void Update()
    {
        Vector3 displacement = motionDirection * speed * Time.deltaTime;
        transform.position += displacement;
    }
}
