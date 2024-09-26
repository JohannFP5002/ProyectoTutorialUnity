using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{
    //Variables
    // El Tipo de Dato     Nombre
    int Numerosaltos = 0 ;

    public int PrimerLogroSaltos = 5;
    public int SegundoLogroSaltos = 10;
    public int TercerLogroSaltos = 15;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision InfoChoque)
    {
        Numerosaltos = Numerosaltos + 1;
        Debug.Log("Numero de Choques: " + Numerosaltos + " " + gameObject.name + " ha chocado con " + InfoChoque.gameObject.name);
        
        if (Numerosaltos == PrimerLogroSaltos || Numerosaltos == SegundoLogroSaltos || Numerosaltos == TercerLogroSaltos)
        {
            Debug.Log("El " + gameObject.name + " ha chocado " + Numerosaltos + " veces!!");
        }        
    }
}
