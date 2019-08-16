using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{
    public float thrust;
    public float thrust2;
    public Rigidbody rb;
    public float spawned;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(0, thrust2, thrust, ForceMode.Impulse);
    }

    void Update()
    {
        spawned += Time.deltaTime;
        if (spawned > 2)
        {
            Destroy(gameObject);
        }

    }
}
