using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public Canvas MyCanvas;
    public NextButton MyNextButton;
    // Start is called before the first frame update
    void Start()
    {
        MyCanvas = FindObjectOfType<Canvas>();
        MyNextButton= FindObjectOfType<NextButton>();

        MyNextButton.GetComponent<Image>().enabled = false;
        
        //MyCanvas.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.C))
        {
            if (Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.KeypadPlus))
                {
                    MyNextButton.GetComponent<Image>().enabled = true;
                }

            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            MyNextButton.GetComponent<Image>().enabled = true;
        }
    }
}
