using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class visualizadorscript : MonoBehaviour
{
    public GameObject[] producto1;
    public GameObject[] producto2;
    int factorderecho;
    int factorizquierdo;
    public Text PrecioIzq;
    public Text PrecioDer;
    public InputField respuesta;
    public GameObject respcorrecta;
    public GameObject respincorrecta;
    public GameObject inputvacío;

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
            respcorrecta.SetActive(false);
            respincorrecta.SetActive(false);
            inputvacío.SetActive(false);

        }
    }

    void Activate()
    {
        factorizquierdo = Random.Range(0, producto1.Length);
        factorderecho = Random.Range(0, producto2.Length);
        producto1[factorizquierdo].transform.position = new Vector3(6f, 0f, 0f);
        producto2[factorderecho].transform.position = new Vector3(-6f, 0f, 0f);
        producto1[factorizquierdo].SetActive(true);
        producto2[factorderecho].SetActive(true);
        int precioIzq = producto1[factorizquierdo].GetComponent<productoscript>().precio;
        int precioDer = producto2[factorderecho].GetComponent<productoscript>().precio;
        PrecioIzq.text = "$" + precioIzq.ToString();
        PrecioDer.text = "$" + precioDer.ToString();
    }
    public void BotonPresionado()
    {
        if (respuesta=null)
        {
            inputvacío.SetActive(true);
        }
    }
}
