using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public float movementFactor;
    public float movementFactorMultiplier;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        processingMovement();
    }

    void processingMovement()
    {
        float finalMovementFactor = movementFactor;
        if (Input.GetButton("CameraSpeedUp"))
        {
            finalMovementFactor *= movementFactorMultiplier;
        }
        transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * finalMovementFactor * Time.deltaTime,
            transform.position.y + Input.GetAxis("Height") * finalMovementFactor * Time.deltaTime,
            transform.position.z + Input.GetAxis("Vertical") * finalMovementFactor * Time.deltaTime);
    }
}
