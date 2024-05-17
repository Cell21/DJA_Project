using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public MeshRenderer laserMeshRenderer;
    public Collider laserCollider;
    public float timeToTurnOn = 1;
    public float timeToTurnOff = 1;

    private void Start()
    {
        StartCoroutine(LaserAction());
    }

    IEnumerator LaserAction() 
    {
        while (true)
        {
            laserMeshRenderer.enabled = true;
            laserCollider.enabled = true;

            yield return new WaitForSeconds(timeToTurnOff);

            laserMeshRenderer.enabled = false;
            laserCollider.enabled = false;

            yield return new WaitForSeconds(timeToTurnOn);
        }
    }
}
