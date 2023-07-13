using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{
    public Transform MyEndPath;
    public Vector3 MyStartPosition;
    public float MySpeed;
    public bool HeadingForwards;
    // Start is called before the first frame update
    void Start()
    {
        MyStartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (HeadingForwards)
        {
            transform.position = Vector2.MoveTowards(transform.position, MyEndPath.position, 
            MySpeed * Time.deltaTime);

            if(Vector2.Distance(transform.position, MyEndPath.position) < 0.1f)
            {
                HeadingForwards= false;
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, MyStartPosition,
                        MySpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, MyStartPosition) < 0.1f)
            {
                HeadingForwards = true;
            }

        }
    }
}
