using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public Canvas MyCanvas;
    // Start is called before the first frame update
    void Start()
    {
        MyCanvas.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            if (Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.Equals))
                {
                    MyCanvas.enabled = true;
                }

            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            MyCanvas.enabled = true;
        }
    }
}
