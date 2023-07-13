using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenBlock : MonoBehaviour
{
    public GameObject MyBlock;
    public bool IsHidden = false;


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
            IsHidden = !IsHidden;
            MyBlock.SetActive(IsHidden);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            IsHidden = !IsHidden;
            MyBlock.SetActive(IsHidden);
        }
    }
}
