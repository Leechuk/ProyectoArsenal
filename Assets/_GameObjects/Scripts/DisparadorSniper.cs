using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparadorSniper : MonoBehaviour
{
    [SerializeField] GameObject bala; //Prefab
    [SerializeField] Transform pOrigen;
    [SerializeField] int fuerza = 100; //Fuerza que se implementa
    [SerializeField] GameObject prefabImpacto;
    

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

            Debug.DrawRay(pOrigen.position, pOrigen.forward * 100, Color.green, 5);//color de seguimiento
        }
    }

    public void Disparo()
    {
        RaycastHit rch;

        Ray rayito = new Ray(pOrigen.position, pOrigen.forward);
        bool hayImpacto = Physics.Raycast(rayito, out rch);
        //Debug.DrawRay(pOrigen.position, pOrigen.forward * rch.distance, Color.red, Mathf.Infinity);
        //Debug.DrawLine()

        /*bool hayImpacto = Physics.Raycast(
            pOrigen.position,
            pOrigen.forward,
            out rch);*/
        if (hayImpacto)
        {
            print(rch.collider.gameObject.name);
            
            if (rch.collider.gameObject.GetComponent<Rigidbody>() !=null)
            {
                print("Distancia" + rch.distance);// para saber la distancia del impacto
                //rch.collider.gameObject.GetComponent<Rigidbody>().
                //    AddForce(pOrigen.forward.normalized * fuerza);
                //GameObject impacto = Instantiate(prefabImpacto, rch.point, Quaternion.identity); //Impacto independiente
                GameObject impacto = Instantiate(prefabImpacto, rch.transform);
                //impacto.transform.SetParent();
                impacto.transform.position = rch.point;
                impacto.transform.rotation = Quaternion.FromToRotation(Vector3.back, rch.normal);
                impacto.transform.Translate(Vector3.back * 0.01f);
                Debug.DrawRay(rch.point, rch.normal, Color.blue, 10);

            }
        }


    }

}
