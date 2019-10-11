using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorGranadas : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Alpha4)) 
        {
            Disparo();

            print("Dispara");
        }
    }

    public void Disparo()
    {
        //Generamos proyectil
        GameObject proyectil = Instantiate(bala);
        // Asigno al proyectil la posicion y rotacion del punto de spanw
        proyectil.transform.position = pOrigen.position;
        proyectil.transform.rotation = pOrigen.rotation;
        // impulsamos proyectil
        proyectil.GetComponent<Rigidbody>().AddForce(proyectil.transform.forward * fuerza);
    }

}
