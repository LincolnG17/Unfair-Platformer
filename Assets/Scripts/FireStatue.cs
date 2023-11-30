using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStatue : MonoBehaviour
{
    public float TimeBetweenShots;
    public GameObject FireBall;
    // Update is called once per frame

    private void Awake()
    {
        Invoke("ShootFireball", TimeBetweenShots);
    }
    void Update()
    {
        
    }

    void ShootFireball()
    {
        Instantiate(FireBall, transform.position, Quaternion.identity);
        Invoke("ShootFireball", TimeBetweenShots);
    }
}
