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
            Vector3 PlayerSpawn = collision.GetComponent<Player>().MyStartPosition;






            collision.gameObject.transform.SetPositionAndRotation(PlayerSpawn, Quaternion.identity);
        }
    }
}
