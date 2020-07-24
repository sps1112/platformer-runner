using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float scoreValue;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().AddScore(scoreValue);
            GetComponent<Animator>().SetTrigger("Collect");
            Invoke("End", 0.2f);
        }
    }

    void End()
    {
        this.gameObject.SetActive(false);
    }
}
