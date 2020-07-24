using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject[] collectibles;

    int index = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Point")
        {
            SetCollectible(other.gameObject.transform.position);
        }
        else
        {
            Debug.Log(other.gameObject.tag + "  " + other.gameObject.name);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

    }

    void SetCollectible(Vector3 spawnPosition)
    {
        collectibles[index].transform.position = spawnPosition;
        collectibles[index].SetActive(true);
        index++;
        index %= collectibles.Length;
    }
}
