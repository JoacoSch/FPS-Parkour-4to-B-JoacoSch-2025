using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("contact with" + collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
