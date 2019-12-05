using static Utils.Constantes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
using UnityEngine.UI;

public class ControladorDelJuego : MonoBehaviour
{
    public SeleccionDePersonaje SeleccionDePersonaje;
    public Text TextoPuntos;
    public Camera cameraThird;
    public Camera cameraPlane;
    private int _puntos;
    
    private void Start()
    {
        _puntos = 0;
        TextoPuntos.text = "0000";

        var personaje = Instantiate(SeleccionDePersonaje.personaje, transform);
        FindObjectOfType<SeguidorDePersonaje>().AsignarPersonajeYSeguir(personaje);
    }

    void Update()
    {
        if(this.SePresionoLaTecla(KeyCode.Space)){
            Debug.Log("Se presiono la tecla espacio");
            if(cameraPlane.enabled){

            this.DesactivarCamara(cameraPlane);
            this.ActivarCamara(cameraThird);
            } else
            {
            this.DesactivarCamara(cameraThird);
            this.ActivarCamara(cameraPlane);
            }
         
           
        }

    }


    public void sumarPuntos(int puntosASumar)
    {
        _puntos += puntosASumar;
        TextoPuntos.text = _puntos.ToString();
    }
}
