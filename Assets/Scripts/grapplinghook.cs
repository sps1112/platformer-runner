using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grapplinghook : MonoBehaviour
{
    DistanceJoint2D joint;
    Vector3 targetPos;

    public float maxDistance = 10f;
    GameObject player;
    
    void Start()
    {
        joint = GetComponent<DistanceJoint2D>();
        joint.enabled = false;
       
    }

    
    void Update() {

       

        if (Input.GetKeyDown(KeyCode.E))
        {
           
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            float playerDis = Vector2.Distance(new Vector2(transform.position.x, transform.position.y), worldPoint);

            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero,0.1f);

            if (hit.rigidbody != null && (maxDistance >= playerDis) )
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
