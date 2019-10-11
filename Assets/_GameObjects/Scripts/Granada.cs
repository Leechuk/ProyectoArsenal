using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granada : MonoBehaviour
{

    [SerializeField] float retardo;
    [SerializeField] float radio;
    [SerializeField] float salto;
    [SerializeField] float fuerzaExplosion;
    [SerializeField] LayerMask capa;

    private void Start()
    {
        Invoke("Explotar", retardo);
    }

    

    private void Explotar()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, radio, capa.value);
        foreach(Collider c in cols)
        {
            if (c.gameObject.GetComponent<Rigidbody>() != null)
            {
                c.gameObject.GetComponent<Rigidbody>().AddExplosionForce(fuerzaExplosion, transform.position, radio, salto);
            }

            
        }
    }


}


