using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpounerControler : MonoBehaviour
{
    public Transform ObjectToSpawn;
    public Transform LeftLimit;
    public Transform RightLimit;

    
    void Start()
    {
        InvokeRepeating("Spawn", 0,1);
    }

    // Update is called once per frame
    void Spawn()
    {
        Instantiate(ObjectToSpawn, gameObject.transform.position, Quaternion.identity);
    Vector3 newPosition = gameObject.transform.position;
            newPosition.x = Random.Range(LeftLimit.position.x,RightLimit.position.x);
            gameObject.transform.position = newPosition;


    }
}
