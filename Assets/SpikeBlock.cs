using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBlock : MonoBehaviour
{
    public GameObject MyBlock;
    public GameObject MySpike;
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
            MySpike.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            MyAnimator.SetBool("PlayerClose", false);
            MySpike.SetActive(false);
        }
    }
}
