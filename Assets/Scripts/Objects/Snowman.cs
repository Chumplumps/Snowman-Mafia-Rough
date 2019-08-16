using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour
{
    List<Collider> colliders = new List<Collider>();

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Snowball")
        {
            Destroy(gameObject);
        }
    }
}
