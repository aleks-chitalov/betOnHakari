using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float moveSpeed = 10f;
    // Update is called once per frame
    void Update()
    {
       float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement vector
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f); 
        movement *= moveSpeed * Time.deltaTime;
        // Apply movement to the cube
        transform.Translate(Vector3.ClampMagnitude(movement, 1f)); 
    }
}
