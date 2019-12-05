using static Utils.Constantes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class RecogerFruta : MonoBehaviour
{

    ControladorDelJuego _controladorDelJuego = new ControladorDelJuego();
    
    // Start is called before the first frame update
    void Start()
    {

       _controladorDelJuego = this.EncontrarObjetoDelTipo<ControladorDelJuego>(); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider colisionador)
    {
        if (colisionador.ContieneLaEtiqueta("Player"))
        {
            _controladorDelJuego.sumarPuntos(10);
            this.Ocultar();
        }


    }
}
