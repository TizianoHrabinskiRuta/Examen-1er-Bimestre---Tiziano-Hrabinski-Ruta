using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class TICapalooza : MonoBehaviour
{

    public int VentasEnCampo;
    public int VentasEnPlatea;
   

    // Start is called before the first frame update
    void Start()
    {
        if(VentasEnCampo < 0 || VentasEnCampo > 20400)
        {
            Debug.Log("Ingreso un numero invalido para los cupos de Campo. Asegurese de que sea entre 0 y 20,400");
            return;
        }

        if(VentasEnPlatea < 0 || VentasEnPlatea > 16200)
        {
            Debug.Log("Ingreso un numero invalido para los cupos de Platea. Asegurese de que sea entre 0 y 16,200");
            return;
        }

        float RecaudoCampo = VentasEnCampo * 1200;
        float RecaudoPlatea = VentasEnPlatea * 2000;
        float RecaudoTotal = RecaudoCampo + RecaudoPlatea;
        int EspacioVendido = VentasEnPlatea + VentasEnCampo;


        Debug.Log("En campo se recaudó un total de " + Convert.ToString(RecaudoCampo));
        Debug.Log("En Platea se recaudó un total de " + RecaudoPlatea.ToString());
        Debug.Log("En total, las dos recaudaron " + RecaudoTotal.ToString());

        Debug.Log("Quedoaron vacantes: " + Convert.ToString(36600 - EspacioVendido));
        if(EspacioVendido == 36600)
        {
            Debug.Log("Sold Out!");
        }

        if (EspacioVendido > 18300) Debug.Log("El festival fue un exito!");
        else Debug.Log("Debemos mejorar la convocatoria");
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
