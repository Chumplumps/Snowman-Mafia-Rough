using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySnowball : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;
    public float spawned;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.forward * thrust);
    }

    void Update()
    {
        spawned += Time.deltaTime;
        if (spawned > 4)
        {
            Destroy(gameObject);
        }

    }
}
