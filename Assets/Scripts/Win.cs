using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collision is with the ball
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("You win!");
        }
    }
}
