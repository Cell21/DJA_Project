using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public MeshRenderer laserMeshRenderer;
    public Collider laserCollider;
    public float timeToTurnOn = 1;
    public float timeToTurnOff = 1;
    public bool turnOffWithObstacle = false;
    public bool isTurnedOn = true;
    public LayerMask invisibleLayer;


    private void Start()
    {
        StartCoroutine(LaserAction());
    }

    IEnumerator LaserAction() 
    {
        while (true)
        {
            if (isTurnedOn) 
            {
                laserMeshRenderer.enabled = true;
                laserCollider.enabled = true;
            }
            

            yield return new WaitForSeconds(timeToTurnOff);

            if (isTurnedOn) 
            {
                laserMeshRenderer.enabled = false;
                laserCollider.enabled = false;
            }
            
            yield return new WaitForSeconds(timeToTurnOn);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Default") && turnOffWithObstacle) 
        {
            int invisibleLayerIndex = Mathf.RoundToInt(Mathf.Log(invisibleLayer.value, 2));
            gameObject.layer = invisibleLayerIndex;
            isTurnedOn = false;
            Debug.Log("Ola");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Default"))
        {
            Debug.Log("Xau");
            gameObject.layer = LayerMask.NameToLayer("Laser");
            isTurnedOn = true;
        }
    }
}
