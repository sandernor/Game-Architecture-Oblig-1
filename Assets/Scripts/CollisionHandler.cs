using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.SetActive(false);
        Debug.LogWarning($"CollidePOG { other.gameObject.name}");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.LogWarning($"Trigger {other.gameObject.name}");
    }

}
