using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform entryPoint;
    public GameObject player;
    public bool alreadyExited;

    // tarkista vielä:
    // player moveSpeed = 0, kun teleportattu
    // NPC teksti ja sijoitus
    // Takaperin teleporttaus
    // Oven keräiltävien vaatimus
    // pelin lopetus
    // Musiikit!

    // Start is called before the first frame update
    void Start()
    {
        alreadyExited = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            alreadyExited = true;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(alreadyExited)
            {
                player.transform.position = spawnPoint.position;
                alreadyExited = false;
            }
        }
        
    }
}
