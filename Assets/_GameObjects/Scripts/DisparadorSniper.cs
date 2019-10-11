using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorSniper : MonoBehaviour
{
    [SerializeField] GameObject bala; //Prefab
    [SerializeField] Transform pOrigen;
    [SerializeField] int fuerza = 100; //Fuerza que se implementa

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2)) 
        {
            Disparo();

            print("Dispara");
        }
    }

    public void Disparo()
    {
        RaycastHit rch;
        bool hayImpacto = Physics.Raycast(
            pOrigen.position,
            pOrigen.forward,
            out rch);
        if (hayImpacto)
        {
            print(rch.collider.gameObject.name);
            
            if (rch.collider.gameObject.GetComponent<Rigidbody>() !=null)
            {
                print("Distancia" + rch.distance);// para saber la distancia del impacto
                rch.collider.gameObject.GetComponent<Rigidbody>().
                    AddForce(pOrigen.forward.normalized * fuerza);
            }
        }


    }

}
