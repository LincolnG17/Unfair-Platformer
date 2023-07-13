using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBlock : MonoBehaviour
{
    public GameObject MyBlock;
    public BoxCollider2D MySpike;
    public Animator MyAnimator;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            MyAnimator.SetBool("PlayerClose", true);
            MySpike.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            MyAnimator.SetBool("PlayerClose", false);
            MySpike.enabled = false;
        }
    }
}
