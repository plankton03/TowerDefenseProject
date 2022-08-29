using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementLimiter : MonoBehaviour
{
    public Transform limiter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LimitCameraMovement();
    }

    private void LimitCameraMovement()
    {

        Vector3 newPosition = new Vector3();

        if (transform.position.x > (limiter.position.x + limiter.localScale.x))
        {
            transform.position = new Vector3(limiter.position.x + limiter.localScale.x ,
                transform.position.y,transform.position.z) ;
        }

        if (transform.position.y > (limiter.position.y + limiter.localScale.y))
        {
            transform.position = new Vector3(transform.position.x,
                limiter.position.y + limiter.localScale.y,transform.position.z) ;
        }

        if (transform.position.z > (limiter.position.z + limiter.localScale.z))
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y,limiter.position.z + limiter.localScale.z) ;
        }

        if (transform.position.x < (limiter.position.x - limiter.localScale.x))
        {
            transform.position = new Vector3(limiter.position.x - limiter.localScale.x ,
                transform.position.y,transform.position.z) ;
        }

        if (transform.position.y < (limiter.position.y - limiter.localScale.y))
        {
            transform.position = new Vector3(transform.position.x,
                limiter.position.y - limiter.localScale.y,transform.position.z) ;
        }

        if (transform.position.z < (limiter.position.z - limiter.localScale.z))
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y,limiter.position.z - limiter.localScale.z) ;
        }
    }
}
