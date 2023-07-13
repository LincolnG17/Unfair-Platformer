using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class THWOMP : MonoBehaviour
{
    public Animator MyAnimator;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            MyAnimator.SetTrigger("SLAM");
        }
    }

}
