using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBox : MonoBehaviour
{
    public Collider2D MyCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            
            SceneReloadCounter MySceneReloadCounter = FindObjectOfType<SceneReloadCounter>();
            collision.attachedRigidbody.velocity= Vector3.zero;
            collision.attachedRigidbody.simulated = false;
            collision.GetComponent<Player>().myAnimator.SetTrigger("Dead");
            MySceneReloadCounter.Invoke("ReloadScene", 2f);
                
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //Vector3 PlayerSpawn = collision.GetComponent<Player>().MyStartPosition;
            //collision.gameObject.transform.SetPositionAndRotation(PlayerSpawn, Quaternion.identity);
        }
    }
}
