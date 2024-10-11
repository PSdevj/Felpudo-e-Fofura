using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFofura : MonoBehaviour
{
    public Vector3 moveSpeed;
    public float spawnTime = 2f;
    public float spawnDelay = 2f;


   

    bool canRun;
    // Use this for initialization
    void Start()
    {
        canRun = true;
        moveSpeed = Vector3.left * Time.deltaTime;
        InvokeRepeating("ChangeSpeed", spawnDelay, spawnTime);

       

    }
    void ChangeSpeed()
    {
        if (canRun == true)
        {
            moveSpeed= new Vector3(Random.Range(-1, -2), 0, 0) * 0.03f;
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += moveSpeed;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            canRun = false;
            moveSpeed = Vector3.zero;
            
        }
    }
}

