using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.R) || transform.position.y <= -10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Laser"))
        {
            if (other.gameObject.GetComponent<Laser>().isTurnedOn) 
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            
        }
    }
}
