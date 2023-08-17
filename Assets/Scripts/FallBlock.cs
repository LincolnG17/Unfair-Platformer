using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBlock : MonoBehaviour
{
    public GameObject MyBlock;
    public Rigidbody2D MyRigidBody2D;
    public RigidbodyConstraints2D MyRigidBodyConstraints2D;


    // Start is called before the first frame update
    void Start()
    {
        MyRigidBody2D = GetComponent<Rigidbody2D>();
        MyRigidBody2D.constraints = RigidbodyConstraints2D.FreezeAll;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            MyRigidBody2D.constraints &= ~RigidbodyConstraints2D.FreezePositionY;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
        }
    }
}
