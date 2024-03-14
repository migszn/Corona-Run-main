using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    public GameObject sound;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        sound = GameObject.FindGameObjectWithTag("sound");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if(collision.tag == "Player")
        {
            Destroy(sound.gameObject);
            Destroy(player.gameObject);
        }
    }
}
