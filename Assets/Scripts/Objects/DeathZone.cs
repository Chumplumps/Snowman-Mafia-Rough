using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    List<Collider> colliders = new List<Collider>();

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Snowman")
        {
            Destroy(gameObject);
        }
    }
}
