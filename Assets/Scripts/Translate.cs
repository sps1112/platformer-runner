using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    public Vector3 motionDirection;

    public float speed;

    GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        Vector3 displacement = motionDirection * speed * Time.deltaTime;
        // float factor = player.GetComponent<Controller>().GetInput();
        //transform.position=factor*displacement;
        transform.position += displacement;
    }
}
