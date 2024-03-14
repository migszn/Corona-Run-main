using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mask : MonoBehaviour
{
    private GameObject player;
    GameObject obj;

    void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Score");
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if (collision.tag == "Player")
        {
            obj.GetComponent<ScoreManager>().score += 5;
            Destroy(this.gameObject);
        }
    }
}
