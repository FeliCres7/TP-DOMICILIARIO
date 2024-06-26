using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visualizadorscript : MonoBehaviour
{
    public GameObject[] producto1;
    public GameObject[] producto2;
    int factorderecho;
    int factorizquierdo;
    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
        Activate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DeactivateAll()
    {
    for (int i=0; i<producto1.Length; i++)
        {
            producto1[i].SetActive(false);
            producto2[i].SetActive(false);
        }
    }

    void Activate()
    {
        factorizquierdo = Random.Range(0, producto1.Length);
        factorderecho = Random.Range(0, producto2.Length);
        GameObject objetoAMover1 = producto1[factorizquierdo];
        Vector3 nuevaPosicion1 = new Vector3(50, 0, 0);
        GameObject objetoAMover2 = producto2[factorderecho];
        Vector3 nuevaPosicion2 = new Vector3(-50, 0, 0);
        producto1[factorizquierdo].SetActive(true);
        producto2[factorderecho].SetActive(true);
    }
}
