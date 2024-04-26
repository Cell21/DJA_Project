using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{
    private bool isCursorLocked = false;
    // Update is called once per frame
    void Update()
    {
        // Get input from arrow keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Adjust rotation based on arrow key input
        float rotationSpeed = 50f;
        float mouseX = horizontalInput * rotationSpeed * Time.deltaTime;
        float mouseY = verticalInput * rotationSpeed * Time.deltaTime;

        // Rotate the object
        transform.Rotate(Vector3.back, mouseX);
        transform.Rotate(Vector3.right, mouseY);
    }
}
