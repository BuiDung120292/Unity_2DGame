using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    protected float speed = 7f;
    protected float distanceLimit = 0.5f;
    
    // Update is called once per frame
    void Update()
    {
        this.Follow();
    }
    void Follow()
    {
        Vector3 distance = this.player.position - transform.position;
        if (distance.magnitude >= this.distanceLimit)
        {
            Vector3 targetPoint = this.player.position - distance.normalized * this.distanceLimit;
            gameObject.transform.position =
                Vector3.MoveTowards(gameObject.transform.position, targetPoint, this.speed * Time.deltaTime);
        }
    }
}
