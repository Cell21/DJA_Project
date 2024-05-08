using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    [SerializeField]
    float windForce = 0f;

    public Vector3 direction;

    private void OnTriggerStay(Collider other)
    {
        var hitObj = other.gameObject;
        if(hitObj != null)
        {
            if (hitObj.CompareTag("Ball")) 
            {
                var rb = hitObj.GetComponent<Rigidbody>();
                //var dir = hitObj.transform.up;
                var dir = direction;
                rb.AddForce(dir * windForce);
            }           
        }    
    }
}
