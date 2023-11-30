using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Boo : MonoBehaviour
{
    Player player;
    public float facingAngleThreshold = 30f;
    public float moveSpeed = 5f;
    public float currentSpeed = 0f;

    public float angle;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        GetDistance();
        
    }

    void GetDistance()
    {
        // Calculate distance between two objects
        float distance = Vector3.Distance(transform.position, player.transform.position);
        Debug.Log("Distance: " + distance);

        // Calculate direction from object1 to object2
        Vector3 directionToBoo = (transform.position -  player.transform.position).normalized;
        Vector3 directionToPlayer = (player.transform.position - transform.position).normalized;
        Debug.Log("Direction: " + directionToBoo);

        angle = Mathf.Atan2(directionToBoo.y, directionToBoo.x) * Mathf.Rad2Deg;

        if (directionToBoo.x < 0 && player.isFacingRight == false || directionToBoo.x > 0 && player.isFacingRight == true)
        {
            Debug.Log("Player is facing Boo!");
            currentSpeed = 0f;
        }
        else
        {
            Debug.Log("Player is not facing Boo.");
            currentSpeed = moveSpeed;
            MoveBoo(directionToPlayer);
        }
    }

    void MoveBoo(Vector3 DirectionToPlayer)
    {
        if (currentSpeed != 0) 
        {
            transform.Translate(DirectionToPlayer * moveSpeed * Time.deltaTime, Space.World);
        }
    }
}
