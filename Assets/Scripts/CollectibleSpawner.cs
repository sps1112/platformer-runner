using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject collectionObject;

    public GameObject[] collectibles;

    int index = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Point")
        {
            int childCount = other.gameObject.transform.childCount;
            if (childCount == 0)
            {
                SetCollectible(other.gameObject);
            }
        }
        else
        {
            Debug.Log(other.gameObject.tag + "  " + other.gameObject.name);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Point")
        {
            int childCount = other.gameObject.transform.childCount;
            if (childCount > 0)
            {
                GameObject childObject = other.gameObject.transform.GetChild(0).gameObject;
                other.gameObject.transform.DetachChildren();
                childObject.transform.SetParent(collectionObject.transform);
                childObject.SetActive(false);
            }
        }
    }
    void SetCollectible(GameObject parentPoint)
    {
        collectibles[index].transform.position = parentPoint.transform.position;
        collectibles[index].SetActive(true);
        collectibles[index].transform.SetParent(parentPoint.transform);
        index++;
        index %= collectibles.Length;
    }
}
