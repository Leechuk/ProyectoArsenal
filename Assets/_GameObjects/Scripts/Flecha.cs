using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flecha : MonoBehaviour
{
    Vector3 prevPos;
    Vector3 currentPOS;
    Vector3 difPos;
    bool primeraVez = true;


    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<BoxCollider>().enabled = false;
        transform.SetParent(other.transform);
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().isKinematic = true;
        transform.SetParent(other.transform);
    }*/

    private void FixedUpdate()
    {
        currentPOS = transform.position;
        if (!primeraVez)
        {
            difPos = currentPOS - prevPos;
            this.transform.forward = difPos.normalized;
        }
        else
        {
            primeraVez = false;
        }
        prevPos = currentPOS;
    }

}
