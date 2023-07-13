using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    public BoxCollider2D MyCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.gameObject.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        }
    }
}
