using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> camaras;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Activar(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Activar(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Activar(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Activar(3);
        }

    }

    

    private void Activar(int i)
    {
        foreach (GameObject go in camaras)
        {
            go.SetActive(false);
        }
        camaras[i].SetActive(true);
    }

}
