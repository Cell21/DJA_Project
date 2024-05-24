using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObstacle : MonoBehaviour
{
    private GameObject map;
    public float speedMultiplier = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        map = GameObject.Find("Mapa");
    }

    // Update is called once per frame
    void Update()
    {
        if (map != null)
        {
            // Get the rotation angle around the x-axis
            float rotationX = map.transform.eulerAngles.x;

            // Normalize the rotation value to a range of 0 to 180 degrees
            if (rotationX > 180) rotationX -= 360;

            // Check if the rotation angle is greater than 1 degree
            if (rotationX > 1)
            {
                float movement = rotationX * speedMultiplier * Time.deltaTime;

                transform.position += new Vector3(0, 0, movement);
            }

            if(rotationX < -1) 
            {
                float movement = rotationX * speedMultiplier * Time.deltaTime;

                // Move the GameObject upwards
                transform.position += new Vector3(0, 0, -movement);
            }
        }
    }
}
