using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    public PlayerController player;
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        player = go.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
       if (other.CompareTag("Bullet")){
        player.Score +=5;
        Destroy(other.gameObject);
        Destroy(gameObject);
       }
    }
}
