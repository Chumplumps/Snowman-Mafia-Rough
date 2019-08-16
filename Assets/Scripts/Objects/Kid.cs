using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kid : MonoBehaviour
{
    List<Collider> colliders = new List<Collider>();

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Enemy Snowball")
        {
            Destroy(gameObject);
        }
    }
}
