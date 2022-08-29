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

        Vector3 finalScale = limiter.localScale / 2;

        if (transform.position.x > (limiter.position.x + finalScale.x))
        {
            transform.position = new Vector3(limiter.position.x + finalScale.x ,
                transform.position.y,transform.position.z) ;
        }

        if (transform.position.y > (limiter.position.y + finalScale.y))
        {
            transform.position = new Vector3(transform.position.x,
                limiter.position.y + finalScale.y,transform.position.z) ;
        }

        if (transform.position.z > (limiter.position.z + finalScale.z))
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y,limiter.position.z + finalScale.z) ;
        }

        if (transform.position.x < (limiter.position.x - finalScale.x))
        {
            transform.position = new Vector3(limiter.position.x - finalScale.x ,
                transform.position.y,transform.position.z) ;
        }

        if (transform.position.y < (limiter.position.y - finalScale.y))
        {
            transform.position = new Vector3(transform.position.x,
                limiter.position.y - finalScale.y,transform.position.z) ;
        }

        if (transform.position.z < (limiter.position.z - finalScale.z))
        {
            transform.position = new Vector3(transform.position.x,
                transform.position.y,limiter.position.z - finalScale.z) ;
        }
    }
}
