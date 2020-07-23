using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relocate : MonoBehaviour
{
    public bool isLast;

    public GameObject otherObject;

    public float xOrigin;

    void Update()
    {
        if (!isLast)
        {
            if (transform.position.x > xOrigin)
            {
                otherObject.transform.position = transform.position - (otherObject.transform.position - transform.position);
                isLast = true;
                otherObject.GetComponent<Relocate>().isLast = false;
            }
        }
        else
        {
            if (transform.position.x < xOrigin)
            {
                otherObject.transform.position = transform.position + (transform.position - otherObject.transform.position);
                isLast = false;
                otherObject.GetComponent<Relocate>().isLast = true;
            }
        }
    }
}
