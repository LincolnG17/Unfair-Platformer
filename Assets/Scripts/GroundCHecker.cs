using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCHecker : MonoBehaviour
{
    bool isOnGround;
    public Player MyPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag != "Detection")
        {
            isOnGround = true;
            MyPlayer.isOnGround = true;
            MyPlayer.myAnimator.SetBool("Grounded", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        MyPlayer.isOnGround = false;
        isOnGround = false;
        MyPlayer.myAnimator.SetBool("Grounded", false);
    }
}
