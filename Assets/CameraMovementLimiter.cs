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
            newPosition += (limiter.position.x + limiter.localScale.x) * Vector3.right;
        }

        if (transform.position.y > (limiter.position.y + limiter.localScale.y))
        {
            newPosition += (limiter.position.y + limiter.localScale.y) * Vector3.up;
        }

        if (transform.position.z > (limiter.position.z + limiter.localScale.z))
        {
            newPosition += (limiter.position.z + limiter.localScale.z) * Vector3.forward;
        }

        if (transform.position.x < (limiter.position.x - limiter.localScale.x))
        {
            newPosition += (limiter.position.x - limiter.localScale.x) * Vector3.right;
        }

        if (transform.position.y < (limiter.position.y - limiter.localScale.y))
        {
            newPosition += (limiter.position.y - limiter.localScale.y) * Vector3.up;
        }

        if (transform.position.z < (limiter.position.z - limiter.localScale.z))
        {
            newPosition += (limiter.position.z - limiter.localScale.z) * Vector3.forward;
        }

        if (newPosition != Vector3.zero)
        {
            transform.position = newPosition;
        }
    }
}
