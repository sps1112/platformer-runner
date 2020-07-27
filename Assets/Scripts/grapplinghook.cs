using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grapplinghook : MonoBehaviour
{
    DistanceJoint2D joint;
    Vector3 targetPos;
   
    public float distance = 10f;
    GameObject player;
    
    void Start()
    {
        player = GameObject.FindWithTag("Player");
       
        joint = GetComponent<DistanceJoint2D>();
        joint.enabled = false;
       
    }

    
    void Update() {


        player.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        if (Input.GetKeyDown(KeyCode.E))
        {
           
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero,10.0f);

            if (hit.rigidbody != null)
            {
                Debug.Log("Yes");

                joint.enabled = true;
               
                joint.connectedAnchor = new Vector2(worldPoint.x, worldPoint.y + 1f);
                joint.distance = 0f;
               
            }
        }
        if (Input.GetKeyUp(KeyCode.E)) { joint.enabled = false;
            
        }
    }
}
